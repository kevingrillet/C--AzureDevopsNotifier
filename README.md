<div align="center">
   <a href="https://github.com/kyechan99/capsule-render">
      <img align="center" src="https://capsule-render.vercel.app/api?type=waving&color=gradient&height=250&section=header&text=CSharp&fontAlign=30&fontAlignY=30&fontSize=80&desc=AzureDevopsNotifier&descAlign=60&descAlignY=55&descSize=70" />
   </a>
   <br>
   <a href="https://github.com/dependabot">
      <img align="center" alt="Dependabot" src="https://img.shields.io/badge/dependabot-025E8C?style=for-the-badge&logo=dependabot&logoColor=white" />
   </a>
   <a href="https://www.microsoft.com/fr-fr/windows/">
      <img align="center" alt="Windows 10/11" src="https://img.shields.io/badge/Windows%2010-0078D6?style=for-the-badge&logo=windows&logoColor=white" />
   </a>
   <a href="https://visualstudio.microsoft.com/fr/">
      <img align="center" alt="Visual Studio" src="https://img.shields.io/badge/Visual%20Studio-5C2D91.svg?style=for-the-badge&logo=visual-studio&logoColor=white" />
   </a>
   <a href="https://learn.microsoft.com/fr-fr/dotnet/">
      <img align="center" alt=".NET" src="https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white" />
   </a>
   <br />
   <a href="https://discord.gg/scdUu3SUQm">
      <img align="center" alt="Discord" src="https://img.shields.io/discord/914218630214983730?label=Discord&logo=Discord" />
   </a>
   <hr>
</div>

# C#-AzureDevopsNotifier

C# AzureDevops Notifier (PR, WorkItems -> Bugs, ...)

## Configuration

Edit `Configurations\AzureDevOpsSettings.json`:

- `Delay` Delay between calls
- `OrganizationUrl` The name of the Azure DevOps organization
- `PersonalAccessToken`
- `ProjectName` Project name
- `Queries` ajoutera des éléments qui ne sont pas dans le dossier dans une catégorie séparée:
  - For WorkItems
    - `Type: 0`
    - `Name`
    - `Filters` [Array of Wiql where condition](<https://learn.microsoft.com/en-us/azure/devops/boards/queries/wiql-syntax?view=azure-devops#where-clause>)
    - `Running`
  - For PR
    - `Type: 1`
    - `Name`
    - `RepositoryName`
    - `Running`

```json
{
    "Delay": 5,
    "OrganizationUrl": "https://dev.azure.com/[OrganizationUrl]/",
    "PersonalAccessToken": "PersonalAccessToken",
    "ProjectName": "ProjectName",
    "Queries": [
        {
            "Filters": [
                "[System.WorkItemType] = 'Bug'",
                "[System.TeamProject] = 'ProjectName'",
                "[System.State] <> 'Closed'"
            ],
            "Name": "Open Bugs",
            "Running": true,
            "Type": 0
        },
        {
            "Name": "PRs",
            "RepositoryName": "RepositoryName",
            "Running": true,
            "Type": 1
        }
    ]
}

```

## Licence

```text
 /*
 * ----------------------------------------------------------------------------
 * "LICENCE BEERWARE" (Révision 42):
 * kevingrillet a créé ce fichier. Tant que vous conservez cet avertissement,
 * vous pouvez faire ce que vous voulez de ce truc. Si on se rencontre un jour et
 * que vous pensez que ce truc vaut le coup, vous pouvez me payer une bière en
 * retour. Poul-Henning Kamp
 * ----------------------------------------------------------------------------
 */
```

<div align="center">
   <a href="https://github.com/kyechan99/capsule-render">
      <img align="center" src="https://capsule-render.vercel.app/api?section=footer&type=waving&color=gradient&height=100" />
   </a>
</div>
