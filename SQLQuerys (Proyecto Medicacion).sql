
/*---------------BUSCAR TODAS LAS ALERGIAS QUE TIENE UNA PERSONA------------------------*/
SELECT Componente.Id_Componente, Componente  FROM Componente JOIN Alergia ON Alergia.Id_Componente = Componente.Id_Componente JOIN Persona ON Alergia.Id_Persona = Persona.Id_Persona WHERE Persona.Id_Persona =2; 
/*---------------------------------------------------------------------------------------*/
