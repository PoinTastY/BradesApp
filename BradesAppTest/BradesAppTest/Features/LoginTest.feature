Feature: BradesAppTest
@Run
Scenario: 1 Ejecutar la plicacion
	Given Ejecuto la aplicacion
	Then Espero el siguiente escenario

@LegalLeyends
Scenario: 2 Abrir y cerrar Leyendas Legales
	Given Abro el menu oculto
	And Doy Click en Leyendas Legales
	And Voy a Aviso Legal
	And Voy a Aclaraciones
	Then Regreso al inicio de sesion

@Help
Scenario: 3 Abrir y cerrar Ayuda
	Given Doy Click en Ayuda
	And Doy click en Chat
	And Doy click en Telefono
	Then Regreso al inicio de sesion




