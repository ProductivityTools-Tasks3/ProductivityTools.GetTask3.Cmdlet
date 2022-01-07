#
# Module manifest for module 'ProductivityTools.PSDisplayPosition'
#
# Generated by: pwujczyk
#
# Generated on: 18.05.2020
#

@{

# Script module or binary module file associated with this manifest.
RootModule = 'ProductivityTools.GetTask3.dll'

# Version number of this module.
ModuleVersion = '0.0.19'

# ID used to uniquely identify this module
GUID = '493b9fb8-d8ca-472d-bb71-65767c9e9714'

# Author of this module
Author = 'Pawel wujczyk'

# Description of the functionality provided by this module
Description = 'It is a cmdlet which allows to manage tasks from powershell'

# Cmdlets to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no cmdlets to export.
CmdletsToExport = @('Add-DefinedTask','Add-Task3','Delay-Task3','Delete-Task3','Finish-Task3','Get-PredefinedTask3','Undone-Task3','Finish-Tomato3','Get-DefinedTask3','Get-Task3','Get-TaskReport3','Get-TomatoReport3','Move-Task3','New-Tomato3','Select-Task3','Start-Task3')

# List of all files packaged with this module
FileList=@(
'IdentityModel.dll',
'Markdig.Signed.dll',
'Microsoft.ApplicationInsights.dll',
'Microsoft.CodeAnalysis.CSharp.dll',
'Microsoft.CodeAnalysis.dll',
'Microsoft.Extensions.Configuration.Abstractions.dll',
'Microsoft.Extensions.Configuration.dll',
'Microsoft.Extensions.Configuration.FileExtensions.dll',
'Microsoft.Extensions.Configuration.Json.dll',
'Microsoft.Extensions.FileProviders.Abstractions.dll',
'Microsoft.Extensions.FileProviders.Physical.dll',
'Microsoft.Extensions.FileSystemGlobbing.dll',
'Microsoft.Extensions.Primitives.dll',
'Microsoft.IdentityModel.JsonWebTokens.dll',
'Microsoft.IdentityModel.Logging.dll',
'Microsoft.IdentityModel.Tokens.dll',
'Microsoft.Win32.Registry.AccessControl.dll',
'Microsoft.Win32.SystemEvents.dll',
'Namotion.Reflection.dll',
'Newtonsoft.Json.Bson.dll',
'Newtonsoft.Json.dll',
'NJsonSchema.dll',
'ProductivityTools.ConsoleColors.dll',
'ProductivityTools.DescriptionValue.dll',
'ProductivityTools.GetTask3.Client.Calls.dll',
'ProductivityTools.GetTask3.Client.Calls.pdb',
'ProductivityTools.GetTask3.Client.dll',
'ProductivityTools.GetTask3.Client.pdb',
'ProductivityTools.GetTask3.dll',
'ProductivityTools.GetTask3.pdb',
'ProductivityTools.GetTask3.Contract.dll',
'ProductivityTools.GetTask3.CoreObjects.dll',
'ProductivityTools.GetTask3.Sdk.dll',
'ProductivityTools.MasterConfiguration.dll',
'ProductivityTools.PSCmdlet.dll',
'System.CodeDom.dll',
'System.ComponentModel.Composition.dll',
'System.ComponentModel.Composition.Registration.dll',
'System.Configuration.ConfigurationManager.dll',
'System.Data.Odbc.dll',
'System.Data.OleDb.dll',
'System.Data.SqlClient.dll',
'System.Diagnostics.EventLog.dll',
'System.Diagnostics.PerformanceCounter.dll',
'System.DirectoryServices.AccountManagement.dll',
'System.DirectoryServices.dll',
'System.DirectoryServices.Protocols.dll',
'System.Drawing.Common.dll',
'System.IdentityModel.Tokens.Jwt.dll',
'System.IO.Packaging.dll',
'System.IO.Ports.dll',
'System.Management.Automation.dll',
'System.Management.dll',
'System.Net.Http.Extensions.dll',
'System.Net.Http.Formatting.dll',
'System.Net.Http.Primitives.dll',
'System.Net.Http.WinHttpHandler.dll',
'System.Private.ServiceModel.dll',
'System.Reflection.Context.dll',
'System.Runtime.Caching.dll',
'System.Runtime.CompilerServices.Unsafe.dll',
'System.Security.Cryptography.Pkcs.dll',
'System.Security.Cryptography.ProtectedData.dll',
'System.Security.Cryptography.Xml.dll',
'System.Security.Permissions.dll',
'System.ServiceModel.dll',
'System.ServiceModel.Duplex.dll',
'System.ServiceModel.Http.dll',
'System.ServiceModel.NetTcp.dll',
'System.ServiceModel.Primitives.dll',
'System.ServiceModel.Security.dll',
'System.ServiceModel.Syndication.dll',
'System.ServiceProcess.ServiceController.dll',
'System.Threading.AccessControl.dll',
'System.Windows.Extensions.dll'
)

# Private data to pass to the module specified in RootModule/ModuleToProcess. This may also contain a PSData hashtable with additional module metadata used by PowerShell.
PrivateData = @{

    PSData = @{

        # Tags applied to this module. These help with module discovery in online galleries.
        Tags = @('Tasks','Task')

        # A URL to the main website for this project.
        ProjectUri = 'http://productivitytools.tech/xx/'

        # A URL to an icon representing this module.
        IconUri = 'http://cdn.productivitytools.tech/images/PT/ProductivityTools_blue_85px_3.png'

        # ReleaseNotes of this module
        # ReleaseNotes = ''

    } # End of PSData hashtable

} # End of PrivateData hashtable

# HelpInfo URI of this module
 HelpInfoURI = 'http://productivitytools.tech/xx/'

}

