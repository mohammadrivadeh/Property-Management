
Install-Package Microsoft.EntityFrameworkCore.Sqlite -Version 3.1.10 -Verbose
Install-Package Microsoft.EntityFrameworkCore.SqlServer -Version 3.1.10 -Verbose
Install-Package Microsoft.EntityFrameworkCore.Tools -Version 3.1.10 -Verbose

=============================
Add-Migration Initial1 -Verbose
Add-Migration Initial2 -Verbose
.
.
.
.
Add-Migration Initial(n) -Verbose

=================
Update-Database -Verbose
Update-Database -Migration:Initial1
Update-Database -Migration:0
Remove-Migration -Verbose
=====================
Update-Database -Migration:0;Remove-Migration -Verbose;Add-Migration Initial1 -Verbose;Update-Database -Verbose