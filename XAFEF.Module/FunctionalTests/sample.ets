;#DropDB XAFEFEasyTest

#Application XAFEFWin
#Application XAFEFWeb

*FillForm
 User Name = Admin
*Action Log In

#IfDef XAFEFWin

*Action About...
 
*Action OK

#EndIf

#IfDef XAFEFWeb
*Action Navigation(My Details)
#EndIf
