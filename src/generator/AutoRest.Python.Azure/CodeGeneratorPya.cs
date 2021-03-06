// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoRest.Core.Model;
using AutoRest.Extensions.Azure;
using AutoRest.Python.Azure.Model;
using AutoRest.Python.Azure.Properties;
using AutoRest.Python.Azure.Templates;
using AutoRest.Python.Templates;

namespace AutoRest.Python.Azure
{
    public class CodeGeneratorPya : CodeGeneratorPy
    {
        private const string ClientRuntimePackage = "msrestazure version 0.4.7";

        public override string UsageInstructions => string.Format(CultureInfo.InvariantCulture,
            Resources.UsageInformation, ClientRuntimePackage);


        /// <summary>
        /// Generate Python client code for given ServiceClient.
        /// </summary>
        /// <param name="cm"></param>
        /// <returns></returns>
        public override async Task Generate(CodeModel cm)
        {
            
            var codeModel = cm as CodeModelPya;
            if (codeModel == null)
            {
                throw new Exception("CodeModel is not a Python Azure Code Model");
            }

            // Service client
            string[] namespaceParts = codeModel.Namespace.Split('.');
            for (int i=1; i<namespaceParts.Length; ++i)
            {
                string initFolderName = Path.Combine(namespaceParts.Take(i).ToArray());
                await Write("__import__('pkg_resources').declare_namespace(__name__)",
                            Path.Combine(initFolderName, "__init__.py"), true);
            }

            var folderName = Path.Combine(codeModel.Namespace.Split('.'));
            var setupTemplate = new SetupTemplate { Model = codeModel };
            await Write(setupTemplate, "setup.py");

            var serviceClientInitTemplate = new ServiceClientInitTemplate { Model = codeModel };
            await Write(serviceClientInitTemplate, Path.Combine(folderName, "__init__.py"));

            var serviceClientTemplate = new AzureServiceClientTemplate { Model = codeModel, };
            await Write(serviceClientTemplate, Path.Combine(folderName, codeModel.Name.ToPythonCase() + ".py"));

            var versionTemplate = new VersionTemplate { Model = codeModel, };
            await Write(versionTemplate, Path.Combine(folderName, "version.py"));

            var exceptionTemplate = new ExceptionTemplate { Model = codeModel, };
            await Write(exceptionTemplate, Path.Combine(folderName, "exceptions.py"));

            var credentialTemplate = new CredentialTemplate { Model = codeModel, };
            await Write(credentialTemplate, Path.Combine(folderName, "credentials.py"));

            //Models
            var models = codeModel.ModelTemplateModels.Where(each => !each.Extensions.ContainsKey(AzureExtensions.ExternalExtension));
            if (models.Any())
            {
                var modelInitTemplate = new AzureModelInitTemplate
                {
                    Model = codeModel
                };
                await Write(modelInitTemplate, Path.Combine(folderName, "models", "__init__.py"));

                foreach (var modelType in models)
                {
                    var modelTemplate = new ModelTemplate { Model = modelType };
                    await Write(modelTemplate, Path.Combine(folderName, "models", modelType.Name.ToPythonCase() + ".py"));
                }
            }

            //MethodGroups
            if (codeModel.MethodGroupModels.Any())
            {
                var methodGroupIndexTemplate = new MethodGroupInitTemplate
                {
                    Model = codeModel
                };
                await Write(methodGroupIndexTemplate, Path.Combine(folderName, "operations", "__init__.py"));

                foreach (var methodGroupModel in codeModel.MethodGroupModels)
                {
                    var methodGroupTemplate = new AzureMethodGroupTemplate
                    {
                        Model = methodGroupModel as MethodGroupPya
                    };
                    await Write(methodGroupTemplate, Path.Combine(folderName, "operations", ((string) methodGroupModel.TypeName).ToPythonCase() + ".py"));
                }
            }

            // Enums
            if (codeModel.EnumTypes.Any())
            {
                var enumTemplate = new EnumTemplate { Model = codeModel.EnumTypes };
                await Write(enumTemplate, Path.Combine(folderName, "models", codeModel.Name.ToPythonCase() + "_enums.py"));
            }

            // Page class
            foreach (var pageModel in codeModel.PageModels)
            {
                var pageTemplate = new PageTemplate
                {
                    Model = pageModel
                };
                await Write(pageTemplate, Path.Combine(folderName, "models", pageModel.TypeDefinitionName.ToPythonCase() + ".py"));
            }
        }
    }
}
