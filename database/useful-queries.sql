-- Selects all claims of all users.
SELECT [P].[Identity]  AS [Identity]
      ,[C].[Name] AS [Context]
      ,[M].[Name]  AS [Module]
      ,[CL].[Name]  AS [Claim]
FROM [SIMPLETS].[security].[PrincipalsModulesContextsClaims] [PMCC]
INNER JOIN [SIMPLETS].[security].[Principals] [P] ON
	[PMCC].[PrincipalId] = [P].[Id]
INNER JOIN [SIMPLETS].[security].[Contexts] [C] ON
	[PMCC].[ContextId] = [C].[Id]
INNER JOIN [SIMPLETS].[security].[Modules] [M] ON
	[PMCC].[ModuleId] = [M].[Id]
INNER JOIN [SIMPLETS].[security].[Claims] [CL] ON
	[PMCC].[ClaimId] = [CL].[Id]
WHERE [P].[Identity] LIKE 'aj54280' -- and C.Name like 'Systeme' and M.name like 'Administration' and CL.Name = 'Read'
ORDER BY [C].[Id]

SELECT *
FROM [SIMPLETS].[dbo].[Membres]

SELECT *
FROM [SIMPLETS].[security].[Contexts]

SELECT *
FROM [SIMPLETS].[security].[Principals]