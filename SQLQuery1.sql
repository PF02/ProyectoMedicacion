SELECT  Medicamento.Id_Medicamento, Medicamento.Nombre_Medicamento 
	FROM Medicamento
		LEFT JOIN Composicion_Medicamento ON Composicion_Medicamento.Id_Medicamento = Medicamento.Id_Medicamento
		LEFT JOIN Componente ON Composicion_Medicamento.Id_Componente = Componente.Id_Componente
WHERE NOT EXISTS (SELECT * FROM Componente WHERE Id_Componente = 2)