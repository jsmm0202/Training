# Get-ChildNames Test Module
function Get-ChildName ()
{
  Write-Output (Get-ChildItem | Select-Object "Name")
  
}
