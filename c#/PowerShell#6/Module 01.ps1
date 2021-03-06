# Get-Command - Retrieves a list of all system commands
Get-Command

# Can expand by searching for just a verb or noun
Get-Command -verb "get"
Get-Command -noun "service"

# Get-Help can be used to explain a command 
Get-Help Get-Command
Get-Help Get-Command -examples
Get-Help Get-Command -detailed
Get-Help Get-Command -full


# Most commands can also be passed a -? paramter to get help
Get-Command -?

# Moving around the file tree
# Get-ChildItem lists all items in current path
Get-ChildItem 

# Set-Location will change the current path
Set-Location c:\projects
Set-Location "C:\Presentations\SQL Server"

# Pipelining - combine CmdLets for power
Get-ChildItem | Where-Object { $_.Length -gt 100kb } 

Get-ChildItem | Where-Object { $_.Length -gt 100kb } | Sort-Object Length

# Can break commands up among several lines 
# (note pipe must be last char on line)
Get-ChildItem |
  Where-Object { $_.Length -gt 100kb } |
  Sort-Object Length

# To specify columns in the output and get nice formatting, use Format-Table  
Get-ChildItem |
  Where-Object { $_.Length -gt 100kb } |
  Sort-Object Length |
  Format-Table -Property Name, Length -AutoSize
  
# You can also use the Select-Object to retrieve certain properties from an object
Get-ChildItem | Select-Object Name, Length

# .Net Everywhere
$a = "I am now a PowerShell expert"
$a
$a.Length
$a.GetType()
