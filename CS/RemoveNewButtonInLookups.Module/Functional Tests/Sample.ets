;#DropDB RemoveNewButtonInLookupsEasyTest

#Application RemoveNewButtonInLookupsWin
#Application RemoveNewButtonInLookupsWeb

*Action Navigation(User)

*ProcessRecord
 Full Name = ''

#IfDef RemoveNewButtonInLookupsWeb
*Action Edit
#EndIf
 
*FillForm
 Full Name = Test User
 
*Action Cancel

#IfDef RemoveNewButtonInLookupsWin
*HandleDialog
 Respond = Yes
#EndIf

*CheckFieldValues
 Full Name = ''
