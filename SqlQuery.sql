CREATE DATABASE dbAutobus
GO

USE dbAutobus
GO

CREATE TABLE Choferes(
	ChoferId INT PRIMARY KEY IDENTITY(1,1),
	Nombre NVARCHAR(250) NOT NULL,
	Apellido NVARCHAR(250) NOT NULL,
	FechaNacimiento DATE NOT NULL,
	Cedula NVARCHAR(13) NOT NULL,
)
GO

CREATE TABLE Autobuses(
	AutobusId INT PRIMARY KEY IDENTITY(1,1),
	Marca NVARCHAR(250) NOT NULL,
	Modelo NVARCHAR(250) NOT NULL,
	Placa NVARCHAR(9) NOT NULL,
	Color NVARCHAR(250) NOT NULL,
	Año NVARCHAR(20) NOT NULL
)
GO

CREATE TABLE Rutas(
	RutaId INT PRIMARY KEY IDENTITY(1,1),
	Nombre NVARCHAR(300) NOT NULL
)
GO

CREATE TABLE Asignaciones(
	AsingnacionId INT IDENTITY(1,1),
	ChoferId INT UNIQUE NOT NULL,
	AutobusId INT UNIQUE NOT NULL, 
	RutaId INT NOT NULL, 
	PRIMARY KEY (AsingnacionId),
	FOREIGN KEY (ChoferId) REFERENCES Choferes(ChoferId),
	FOREIGN KEY (AutobusId) REFERENCES Autobuses(AutobusId),
	FOREIGN KEY (RutaId) REFERENCES Rutas(RutaId)
)
GO

--- Insertar registros

--- Choferes
--- Datos generador en https://www.mockaroo.com/
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Ashbey', 'Thatcham', '03/10/1933', '904-1459337-7');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Barnabas', 'Wynn', '10/27/1934', '280-5954287-8');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Essie', 'Fallen', '04/18/1933', '538-7138262-1');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Tonye', 'St Ledger', '01/27/1986', '371-6356395-0');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Cecile', 'Illwell', '04/19/1961', '198-2527525-8');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Theo', 'Zavattari', '04/18/1927', '415-3755799-3');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Leanor', 'Dannatt', '08/03/1943', '725-4459149-8');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Sibeal', 'Closs', '11/10/1987', '175-6249913-8');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Eugen', 'Biddlecombe', '08/01/1962', '166-9597576-9');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Dew', 'Fulun', '02/07/1903', '529-6036679-3');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Miguelita', 'Longmore', '06/06/1950', '479-1357961-8');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Leonore', 'Balaam', '02/25/1901', '757-8461883-5');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Alastair', 'Volette', '01/25/1947', '167-3927366-8');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Dev', 'Mingardo', '01/24/1905', '857-2681263-0');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Nissy', 'McCarthy', '01/15/1985', '242-3616132-2');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Merrily', 'Klazenga', '04/08/1942', '923-1646082-6');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Bellina', 'Woollcott', '05/23/1957', '643-9852111-0');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Gayelord', 'Sollowaye', '12/21/1987', '022-9550384-6');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Lucius', 'Covington', '11/20/1918', '764-1136661-0');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Gale', 'Ennals', '03/26/1956', '967-3203224-0');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Leontyne', 'Libbe', '11/01/1914', '661-4533226-8');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Danita', 'Parker', '08/19/1921', '986-1414863-2');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Ameline', 'Ruxton', '11/14/1977', '564-9089906-4');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Whitney', 'Diloway', '06/25/1924', '079-8131583-6');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Wilow', 'Blunsen', '12/29/1960', '437-4890462-4');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Stefa', 'Reedshaw', '10/10/1950', '379-7777665-0');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Pietra', 'Plaid', '08/26/1940', '600-0048690-6');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Reube', 'Tyne', '07/09/1983', '740-2521539-2');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Thomas', 'Spacey', '09/12/1970', '555-4547996-6');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Joyous', 'Casier', '01/08/1910', '006-0267830-3');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Clerissa', 'Tyhurst', '12/03/1934', '586-3607990-1');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Kylie', 'Jessup', '06/24/1901', '815-2823788-6');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Thalia', 'Kemshell', '10/06/1943', '296-2152253-1');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Hammad', 'Manketell', '08/13/1904', '681-5282893-7');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Anabel', 'Dumbrill', '03/28/1914', '001-3304383-8');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Jaye', 'Geater', '11/03/1910', '593-7281055-7');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Melitta', 'Rassmann', '10/12/1956', '121-8662083-2');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Mommy', 'O''Siaghail', '03/29/1966', '990-9082175-5');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Devy', 'Bremmer', '01/01/1917', '721-8014366-5');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Nils', 'Cabrer', '10/22/1914', '599-5462960-9');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Miriam', 'Kinghorne', '01/14/1923', '465-0068799-4');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Orly', 'Weekland', '12/15/1901', '637-5662810-4');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Penny', 'Caldeyroux', '06/03/1944', '562-1282503-6');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Isak', 'Pirdue', '01/15/1954', '820-3458924-6');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Ezmeralda', 'Rainsdon', '06/02/1946', '192-0177150-3');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Collete', 'Buglar', '11/02/1904', '760-8961141-2');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Catlaina', 'Sains', '11/28/1916', '257-6391228-3');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Drucy', 'Haythorne', '10/07/1953', '914-6988018-5');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Marrissa', 'Blockley', '12/29/1930', '580-7717403-9');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Shandra', 'Jizhaki', '09/23/1984', '278-1518696-0');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Abe', 'Piatek', '09/27/2000', '454-9926171-1');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Freddie', 'Cathie', '04/26/1909', '135-9367182-6');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Ricoriki', 'MacDermand', '04/09/1965', '204-9075024-6');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Gauthier', 'Vowles', '10/25/1981', '260-0868406-1');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Riccardo', 'Flacknoe', '02/27/1915', '783-9482239-9');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Isabella', 'Edmead', '01/04/1959', '456-2999823-7');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Bette', 'Demer', '05/22/1929', '618-9407367-5');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Blythe', 'Learie', '04/25/1953', '801-2136121-7');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Mychal', 'Stryde', '08/26/1942', '487-3066004-7');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Madalena', 'Shay', '12/04/1958', '355-7004157-4');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Sharl', 'Lipp', '04/07/1971', '810-4830736-9');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Tabbatha', 'Hanhart', '04/15/1961', '982-2395139-2');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Lissie', 'Golden', '04/08/2000', '906-7033496-9');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Jesus', 'De Vaux', '04/02/1902', '111-5201904-8');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Wolf', 'Dommerque', '02/05/1921', '402-1559136-4');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Vivianna', 'Farenden', '07/04/1998', '044-9702041-5');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Lucille', 'Dobbson', '03/05/1921', '216-1451906-9');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Esme', 'Hatton', '12/08/1986', '168-7639797-1');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Cathyleen', 'Freeburn', '06/05/1969', '688-9893802-5');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Nappy', 'Dunthorn', '08/13/1976', '534-9915158-3');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Dacey', 'Scimoni', '08/07/1950', '826-3154900-9');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Pearle', 'Winspeare', '11/11/1902', '605-7858812-7');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Babbette', 'Betty', '06/07/1971', '133-1233891-8');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Birgitta', 'Bligh', '04/27/1977', '028-1127166-0');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Lindi', 'Strainge', '04/10/1988', '037-4009000-2');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Anatol', 'Barlas', '07/13/1995', '343-9736531-2');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Anastasia', 'Sarton', '07/10/1960', '233-0281341-8');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Cecilio', 'Killough', '02/23/1952', '390-6397777-5');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Adriaens', 'Whightman', '07/31/1975', '382-8959818-5');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Cullen', 'Rainsbury', '07/20/1902', '671-1156371-9');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Laural', 'Cleife', '11/04/1902', '262-1332150-4');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Shayne', 'Pyecroft', '01/21/1967', '270-8416256-7');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Vernon', 'Wedderburn', '09/29/1903', '398-8803670-1');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Northrup', 'Sandon', '05/16/1970', '203-6037258-8');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Brien', 'Pevie', '11/30/1925', '974-9570761-3');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Aurlie', 'Uridge', '05/15/1987', '371-1707681-5');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Hansiain', 'Scathard', '03/27/1940', '743-1839954-3');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Oralie', 'Terne', '12/02/1999', '344-3495561-4');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Jaimie', 'Banasik', '12/21/1975', '435-9336220-3');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Dalila', 'Apple', '09/18/1952', '956-4851458-6');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Sal', 'Densun', '10/23/1953', '268-4401908-8');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Wilmar', 'Shepperd', '02/27/1918', '479-7719680-4');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Keven', 'McQuillin', '12/21/1944', '728-1792212-0');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Ty', 'Tancock', '11/01/1905', '624-7987710-6');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Maddy', 'Tesche', '06/30/1963', '921-5451424-3');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Austine', 'Dealtry', '12/11/1991', '197-6448151-8');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Merrill', 'Pentecust', '09/21/1919', '026-0907319-5');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Baxie', 'Linder', '07/07/1908', '385-8496117-0');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Elnar', 'Meeny', '11/22/1985', '642-0839418-3');
insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values ('Gnni', 'Elgy', '11/13/1980', '165-6465472-4');
GO

--- Autobuses
--- Datos generador en https://www.mockaroo.com/
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Volkswagen', 'Type 2', 'I223OOG', 'esmeralda', '1991');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Mercedes-Benz', 'E-Class', 'S223GBR', 'carmesí', '2011');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Ford', 'Ranger', 'F223JKH', 'carmesí', '1990');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Toyota', '4Runner', 'O293GFY', 'magenta', '2002');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Volvo', 'V70', 'K243SWL', 'amarillo', '2005');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Acura', 'MDX', 'T223JMM', 'violeta', '2012');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Mercedes-Benz', 'CLS-Class', 'W243LUU', 'magenta', '2012');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Toyota', 'Celica', 'G283FFY', 'violeta', '2003');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Ford', 'Edge', 'D223HWZ', 'carmesí', '2011');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Toyota', 'Camry', 'L263WPJ', 'violeta', '2005');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Nissan', 'Pathfinder', 'O233RGN', 'carmesí', '1995');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Volkswagen', 'rio', 'N213ZGW', 'carmesí', '1996');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Chevrolet', 'Caprice Classic', 'M203WWC', 'azul', '1993');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Volvo', 'XC70', 'S253ILG', 'amarillo', '2005');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Mazda', 'Miata MX-5', 'S213XUB', 'azul', '1996');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Dodge', 'Ram 2500 Club', 'J283OWP', 'esmeralda', '1996');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Volkswagen', 'Cabriolet', 'B253KTX', 'carmesí', '1986');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Pontiac', 'Firefly', 'W263RLU', 'rubí', '1987');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Acura', 'MDX', 'A263GIM', 'rubí', '2008');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Lexus', 'ES', 'L283CVD', 'carmesí', '2010');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Ford', 'Mustang', 'A223FTE', 'rubí', '1984');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Nissan', 'Frontier', 'W213ZJG', 'violeta', '2010');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Plymouth', 'Horizon', 'N203GDQ', 'verde', '1978');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Mitsubishi', 'Eclipse', 'B243AZD', 'cian', '1989');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('BMW', 'M6', 'B213MBR', 'verde', '2010');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('GMC', 'Savana 3500', 'A233VNM', 'rubí', '1998');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Kia', 'Sportage', 'R253ENH', 'cian', '1996');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Mazda', 'MPV', 'J213RTI', 'carmesí', '1998');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Toyota', 'Paseo', 'Z233MUK', 'carmesí', '1997');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Chevrolet', '2500', 'K283XCS', 'esmeralda', '1992');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('GMC', 'Savana 1500', 'K243HYH', 'naranja', '2000');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Mazda', 'B-Series', 'O233ABG', 'carmesí', '1990');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Ford', 'LTD Crown Victoria', 'K233KNO', 'azul', '1989');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Bentley', 'Continental GTC', 'R223NLC', 'rubí', '2012');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Jeep', 'Grand Cherokee', 'T233NPT', 'magenta', '1994');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('GMC', '1500', 'E293PQQ', 'negro', '1996');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Subaru', 'Impreza', 'U203OPW', 'magenta', '1994');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Chevrolet', 'S10', 'X203BYB', 'negro', '1995');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Audi', 'A5', 'W293WSO', 'rojo', '2009');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Porsche', '928', 'N203FMW', 'rubí', '1993');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Chevrolet', 'G-Series G20', 'K273FVT', 'rojo', '1995');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Saab', '9-5', 'X253VNU', 'violeta', '1999');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Audi', 'RS 4', 'Y213EFZ', 'rubí', '2008');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Cadillac', 'DeVille', 'S213UOU', 'blanco', '2004');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Volkswagen', 'Passat', 'P283KLS', 'magenta', '2008');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Audi', 'S4', 'M233KYX', 'marrón', '2004');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Oldsmobile', 'Aurora', 'Z223BFA', 'azul', '1996');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('GMC', 'Sierra 3500', 'Z213FDI', 'negro', '2011');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Volkswagen', 'Rabbit', 'H293VTV', 'naranja', '2006');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Mercedes-Benz', 'C-Class', 'B283PRK', 'cian', '2001');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Chevrolet', 'Suburban 2500', 'S253SAF', 'rojo', '1997');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Mitsubishi', 'Diamante', 'U293OEE', 'azul', '2005');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Ram', '2500', 'Q243PIN', 'amarillo', '2012');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Chrysler', 'LeBaron', 'X233AWH', 'esmeralda', '1992');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Pontiac', 'Grand Prix', 'L273LSK', 'marrón', '2004');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Cadillac', 'XLR', 'D293TMS', 'carmesí', '2004');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Mitsubishi', 'Galant', 'E203RIX', 'rojo', '2000');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Oldsmobile', 'Regency', 'R233ZDZ', 'azul', '1997');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('BMW', '530', 'P263XFM', 'azul', '2001');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Chrysler', 'Imperial', 'F283MJT', 'azul', '1926');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Audi', 'V8', 'C223UTO', 'violeta', '1991');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Nissan', 'Quest', 'V253ODN', 'carmesí', '2000');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Lamborghini', 'Diablo', 'D293VNU', 'amarillo', '1991');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Suzuki', 'SJ', 'G243VBJ', 'carmesí', '1990');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Subaru', 'Legacy', 'C263NZA', 'azul', '2004');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Acura', 'RL', 'L253YUV', 'negro', '1999');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Pontiac', '6000', 'W293WXK', 'carmesí', '1989');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Toyota', 'Prius Plug-in Hybrid', 'S223YBU', 'azul', '2012');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Jeep', 'Liberty', 'F273UFM', 'rojo', '2011');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('GMC', 'Savana 2500', 'R283UNU', 'negro', '2000');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Ford', 'LTD Crown Victoria', 'P283YHJ', 'azul', '1989');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Ferrari', '612 Scaglietti', 'I243JLU', 'carmesí', '2007');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Toyota', 'TundraMax', 'O283ZHO', 'cian', '2007');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Hummer', 'H2', 'O233VRD', 'violeta', '2009');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Volkswagen', 'Rabbit', 'X293AJT', 'rubí', '2009');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Honda', 'Accord', 'W263KOC', 'rojo', '1986');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Ford', 'Expedition', 'Y223ASA', 'magenta', '1999');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Mercedes-Benz', 'SL-Class', 'B233HSJ', 'azul', '1985');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Bentley', 'Continental Flying Spur', 'G263VYF', 'verde', '2007');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Chevrolet', 'Corvette', 'O243JJB', 'rojo', '2012');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Ford', 'F250', 'V283CYO', 'cian', '1999');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Mitsubishi', 'Eclipse', 'B233XUL', 'carmesí', '2005');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Cadillac', 'Catera', 'L273CRD', 'violeta', '1997');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Audi', 'A5', 'X253ENW', 'carmesí', '2008');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Porsche', '911', 'L253XLU', 'azul', '2011');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Acura', 'RSX', 'Z213XTK', 'rubí', '2006');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Saab', '9000', 'U293JFE', 'carmesí', '1991');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Eagle', 'Talon', 'U243FMY', 'naranja', '1997');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Acura', 'Vigor', 'C273JUI', 'azul', '1994');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Hyundai', 'Accent', 'M243RHG', 'cian', '1995');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Saturn', 'Ion', 'U203FDS', 'blanco', '2005');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Honda', 'Passport', 'V223ENI', 'naranja', '1999');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Toyota', 'RAV4', 'Z253UVK', 'verde', '2012');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Nissan', 'Titan', 'J263KPY', 'carmesí', '2007');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Nissan', 'Pathfinder', 'O203XUF', 'blanco', '2012');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Mercury', 'Mystique', 'H233JHC', 'cian', '1999');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Maybach', '57', 'A223GLB', 'carmesí', '2005');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Nissan', 'Cube', 'E253ACE', 'negro', '2010');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Mercury', 'Mariner', 'O283IGH', 'amarillo', '2006');
insert into Autobuses (Marca, Modelo, Placa, Color, Año) values ('Mercedes-Benz', 'R-Class', 'J213XBL', 'negro', '2007');
GO

--- Rutas
--- Datos generador en https://www.mockaroo.com/
insert into Rutas (Nombre) values ('Calle 23i');
insert into Rutas (Nombre) values ('Gardenias');
insert into Rutas (Nombre) values ('Paseo');
insert into Rutas (Nombre) values ('Fauna');
insert into Rutas (Nombre) values ('Respaldo Magnolia');
insert into Rutas (Nombre) values ('Calle Isabela Aguero');
insert into Rutas (Nombre) values ('Cj Lucy Morena');
insert into Rutas (Nombre) values ('Interior 17');
insert into Rutas (Nombre) values ('Calle Amparo');
insert into Rutas (Nombre) values ('Calle Oscar Santana');
insert into Rutas (Nombre) values ('Calle Paralela 17');
insert into Rutas (Nombre) values ('Calle Fausto Maceo');
insert into Rutas (Nombre) values ('Calle Lope De Vega');
insert into Rutas (Nombre) values ('Francisco Del R. Sanchez');
insert into Rutas (Nombre) values ('Call La Batalla');
insert into Rutas (Nombre) values ('El Recodo');
insert into Rutas (Nombre) values ('Calle 18w');
insert into Rutas (Nombre) values ('Calle Trinitaria');
insert into Rutas (Nombre) values ('Calle 17d');
insert into Rutas (Nombre) values ('Calle Diego De Ocampo');
insert into Rutas (Nombre) values ('Calle S2');
insert into Rutas (Nombre) values ('Calle Orquidea');
insert into Rutas (Nombre) values ('Calle Los Manantiales');
insert into Rutas (Nombre) values ('Calle Cb1');
insert into Rutas (Nombre) values ('Calle Fernandez Dominguez');
insert into Rutas (Nombre) values ('Calle Emilio Prud''Homme');
insert into Rutas (Nombre) values ('Calle 7w');
insert into Rutas (Nombre) values ('Calle Marco Polo');
insert into Rutas (Nombre) values ('Calle Minverva Mirabal');
insert into Rutas (Nombre) values ('Calle Tapia');
insert into Rutas (Nombre) values ('Calle Victor Estrella Liz');
insert into Rutas (Nombre) values ('Calle 31a Juan De Dios Ventura');
insert into Rutas (Nombre) values ('Respaldo Escolar Carretera Vieja');
insert into Rutas (Nombre) values ('Calle 48 Calle Colibri');
insert into Rutas (Nombre) values ('Calle 39i');
insert into Rutas (Nombre) values ('Avenida Marcos Del Rosario Interior J');
insert into Rutas (Nombre) values ('Respaldo Cantares');
insert into Rutas (Nombre) values ('Calle Horacio Ortiz Alvarez');
insert into Rutas (Nombre) values ('Calle Hector J Diaz Fray Bartolomé De Las Casas');
insert into Rutas (Nombre) values ('Calle Nuñez De Caceres');
insert into Rutas (Nombre) values ('Calle Fray Bartolome De Las Casas Altagracia');
insert into Rutas (Nombre) values ('Apollo II');
insert into Rutas (Nombre) values ('Respaldo 10 Mutualismo');
insert into Rutas (Nombre) values ('Calle Cesar Sandino');
insert into Rutas (Nombre) values ('Calle Arnulfo Romero');
insert into Rutas (Nombre) values ('Calle 12a');
insert into Rutas (Nombre) values ('Respaldo San Luis');
insert into Rutas (Nombre) values ('Calle Los Pilones');
insert into Rutas (Nombre) values ('Calle Ulises Francisco Espaillat');
insert into Rutas (Nombre) values ('Calle Galatas');
insert into Rutas (Nombre) values ('Respaldo Reyes C Calle Ebano');
insert into Rutas (Nombre) values ('Calle K1');
insert into Rutas (Nombre) values ('Calle Pedro Francisco Bono Mejia');
insert into Rutas (Nombre) values ('Calle H1');
GO

--- Asignaciones
insert into Asignaciones (ChoferId, AutobusId, RutaId) values (93, 2, 7);
insert into Asignaciones (ChoferId, AutobusId, RutaId) values (3, 29, 28);
insert into Asignaciones (ChoferId, AutobusId, RutaId) values (70, 76, 31);
insert into Asignaciones (ChoferId, AutobusId, RutaId) values (56, 58, 18);
insert into Asignaciones (ChoferId, AutobusId, RutaId) values (40, 55, 29);
insert into Asignaciones (ChoferId, AutobusId, RutaId) values (73, 28, 35);
insert into Asignaciones (ChoferId, AutobusId, RutaId) values (10, 54, 19);
insert into Asignaciones (ChoferId, AutobusId, RutaId) values (79, 80, 23);
insert into Asignaciones (ChoferId, AutobusId, RutaId) values (90, 39, 18);
insert into Asignaciones (ChoferId, AutobusId, RutaId) values (49, 97, 54);
insert into Asignaciones (ChoferId, AutobusId, RutaId) values (11, 11, 54);
insert into Asignaciones (ChoferId, AutobusId, RutaId) values (11, 11, 20);
insert into Asignaciones (ChoferId, AutobusId, RutaId) values (12, 12, 20);
GO


--- Consultas
SELECT * FROM dbo.Choferes;
SELECT * FROM dbo.Autobuses;
SELECT * FROM dbo.Rutas;
SELECT * FROM dbo.Asignaciones;
GO

--- JOINs
CREATE VIEW vwChoferesLibres AS
SELECT c.ChoferId, CONCAT(c.Apellido,', ', C.Nombre) as Chofer, c.FechaNacimiento, c.Cedula
FROM dbo.Asignaciones a
FULL JOIN dbo.Choferes c ON (a.ChoferId = c.ChoferId)
where a.ChoferId IS NULL;
GO
---

CREATE VIEW vwAutobusesLibres AS
SELECT ab.*
FROM dbo.Asignaciones a
FULL JOIN dbo.Autobuses ab ON (a.AutobusId = ab.AutobusId)
WHERE a.AutobusId IS NULL;
GO
---

CREATE VIEW vwRutasLibres AS
SELECT r.*
FROM dbo.Asignaciones a
FULL JOIN dbo.Rutas r ON (a.AutobusId = r.RutaId)
WHERE a.RutaId IS NULL;
GO

CREATE VIEW vwAsignaciones AS
SELECT c.ChoferId, CONCAT(c.Apellido,', ',c.Nombre) AS Chofer, c.Cedula, c.FechaNacimiento,
ab.AutobusId, ab.Marca, ab.Modelo, ab.Placa, ab.Color, ab.Año, r.RutaId, r.Nombre as Nombre_Ruta
FROM dbo.Asignaciones a
 JOIN dbo.Rutas r ON (a.AutobusId = r.RutaId)
 JOIN dbo.Autobuses ab ON (a.AutobusId = ab.AutobusId)
 JOIN dbo.Choferes c ON (a.ChoferId = c.ChoferId)
GO


--- Stored Procedure
--- Crear Choferes
CREATE PROCEDURE dbo.CrearChofer
    @nombre NVARCHAR(250),
	@apellido NVARCHAR(250),
	@fechaNacimiento DATE,
	@cedula NVARCHAR(13)
AS
	BEGIN TRANSACTION 
	BEGIN TRY

	insert into Choferes (Nombre, Apellido, FechaNacimiento, Cedula) values (@nombre, @apellido, @fechaNacimiento, @cedula);
	
	COMMIT TRANSACTION 

	END TRY

	BEGIN CATCH

	ROLLBACK TRANSACTION
	PRINT 'Ha ocurrido un error!'

	END CATCH
RETURN 0
GO

CREATE PROCEDURE dbo.ActualizarChofer
	@choferId INT,
    @nombre NVARCHAR(250),
	@apellido NVARCHAR(250),
	@fechaNacimiento DATE,
	@cedula NVARCHAR(13)
AS
	BEGIN TRANSACTION 
	BEGIN TRY

	UPDATE dbo.Choferes
	SET
		Nombre = @nombre,
		Apellido = @apellido,
		FechaNacimiento = @fechaNacimiento,
		Cedula = @cedula
	WHERE
		ChoferId = @choferId

	COMMIT TRANSACTION 

	END TRY

	BEGIN CATCH

	ROLLBACK TRANSACTION
	PRINT 'Ha ocurrido un error!'

	END CATCH
RETURN 0
GO

CREATE PROCEDURE dbo.EliminarChofer
	@choferId INT
AS
	BEGIN TRANSACTION 
	BEGIN TRY

	DELETE FROM dbo.Choferes
	WHERE
		ChoferId = @choferId

	COMMIT TRANSACTION 

	END TRY

	BEGIN CATCH

	ROLLBACK TRANSACTION
	PRINT 'Ha ocurrido un error!'

	END CATCH
RETURN 0
GO

--- Crear Autobuses
CREATE PROCEDURE dbo.CrearAutobuses
    @marca NVARCHAR(250),
	@modelo NVARCHAR(250),
	@placa NVARCHAR(9),
	@color NVARCHAR(250),
	@año NVARCHAR(20)
AS
	BEGIN TRANSACTION 
	BEGIN TRY

	insert into Autobuses (Marca, Modelo, Placa, Color, Año) values (@marca, @modelo, @placa, @color, @año);
	
	COMMIT TRANSACTION 

	END TRY

	BEGIN CATCH

	ROLLBACK TRANSACTION
	PRINT 'Ha ocurrido un error!'

	END CATCH
RETURN 0
GO

CREATE PROCEDURE dbo.ActualizarAutobuses
	@autobusId INT,
    @marca NVARCHAR(250),
	@modelo NVARCHAR(250),
	@placa NVARCHAR(9),
	@color NVARCHAR(250),
	@año NVARCHAR(20)
AS
	BEGIN TRANSACTION 
	BEGIN TRY

	UPDATE dbo.Autobuses
	SET
		Marca = @marca,
		Modelo = @modelo,
		Placa = @placa,
		Color = @color,
		Año = @año
	WHERE
		AutobusId = @autobusId
	COMMIT TRANSACTION 

	END TRY

	BEGIN CATCH

	ROLLBACK TRANSACTION
	PRINT 'Ha ocurrido un error!'

	END CATCH
RETURN 0
GO

CREATE PROCEDURE dbo.EliminarAutobuses
	@autobusId INT
AS
	BEGIN TRANSACTION 
	BEGIN TRY

	DELETE FROM dbo.Autobuses
	WHERE AutobusId = @autobusId

	COMMIT TRANSACTION 

	END TRY

	BEGIN CATCH

	ROLLBACK TRANSACTION
	PRINT 'Ha ocurrido un error!'

	END CATCH
RETURN 0
GO


--- Crear Rutas
CREATE PROCEDURE dbo.CrearRutas
    @nombre NVARCHAR(250)
AS
	BEGIN TRANSACTION 
	BEGIN TRY

	insert into Rutas (Nombre) values (@nombre);
	
	COMMIT TRANSACTION 

	END TRY

	BEGIN CATCH

	ROLLBACK TRANSACTION
	PRINT 'Ha ocurrido un error!'

	END CATCH
RETURN 0
GO

CREATE PROCEDURE dbo.ActualizarRutas
	@rutaId INT,
    @nombre NVARCHAR(250)
AS
	BEGIN TRANSACTION 
	BEGIN TRY

	UPDATE dbo.Rutas
	SET
		Nombre = @nombre
	WHERE
		RutaId = @rutaId
	
	COMMIT TRANSACTION 

	END TRY

	BEGIN CATCH

	ROLLBACK TRANSACTION
	PRINT 'Ha ocurrido un error!'

	END CATCH
RETURN 0
GO

CREATE PROCEDURE dbo.EliminarRutas
	@rutaId INT
AS
	BEGIN TRANSACTION 
	BEGIN TRY

	DELETE FROM dbo.Rutas
	WHERE
		RutaId = @rutaId
	
	COMMIT TRANSACTION 

	END TRY

	BEGIN CATCH

	ROLLBACK TRANSACTION
	PRINT 'Ha ocurrido un error!'

	END CATCH
RETURN 0
GO

--- Crear Asignaciones
CREATE PROCEDURE dbo.CrearAsignaciones
    @choferId INT,
	@autobusId INT,
	@rutaId INT
AS
	BEGIN TRANSACTION 
	BEGIN TRY

	insert into Asignaciones (ChoferId, AutobusId, RutaId) values (3, 29, 28);
	
	COMMIT TRANSACTION 

	END TRY

	BEGIN CATCH

	ROLLBACK TRANSACTION
	PRINT 'Ha ocurrido un error!'

	END CATCH
RETURN 0
GO

CREATE PROCEDURE dbo.ActualizarAsignaciones
	@asignacionId INT,
    @choferId INT,
	@autobusId INT,
	@rutaId INT
AS
	BEGIN TRANSACTION 
	BEGIN TRY

	UPDATE dbo.Asignaciones
	SET
		ChoferId = @choferId,
		AutobusId = @autobusId,
		RutaId = @rutaId
	WHERE
		AsingnacionId = @asignacionId

	COMMIT TRANSACTION 

	END TRY

	BEGIN CATCH

	ROLLBACK TRANSACTION
	PRINT 'Ha ocurrido un error!'

	END CATCH
RETURN 0
GO


CREATE PROCEDURE dbo.EliminarAsignaciones
	@asignacionId INT
AS
	BEGIN TRANSACTION 
	BEGIN TRY

	DELETE FROM dbo.Asignaciones
	WHERE AsingnacionId = @asignacionId

	COMMIT TRANSACTION 

	END TRY

	BEGIN CATCH

	ROLLBACK TRANSACTION
	PRINT 'Ha ocurrido un error!'

	END CATCH
RETURN 0
GO

--- Buscar Asignacion
CREATE PROC BuscarAsignacion
	@parametroBusqueda NVARCHAR(255)
AS
BEGIN
	SELECT * 
	FROM dbo.vwAsignaciones
	WHERE AsingnacionId LIKE '%'+@parametroBusqueda+'%' OR ChoferId LIKE '%'+@parametroBusqueda+'%' OR Chofer LIKE '%'+@parametroBusqueda+'%' OR
		Cedula LIKE '%'+@parametroBusqueda+'%' OR FechaNacimiento LIKE '%'+@parametroBusqueda+'%' OR AutobusId LIKE '%'+@parametroBusqueda+'%' OR
		Marca LIKE '%'+@parametroBusqueda+'%' OR Modelo LIKE '%'+@parametroBusqueda+'%' OR Modelo LIKE '%'+@parametroBusqueda+'%' OR Placa LIKE '%'+@parametroBusqueda+'%' OR
		Color LIKE '%'+@parametroBusqueda+'%' OR Año LIKE '%'+@parametroBusqueda+'%' OR RutaId LIKE '%'+@parametroBusqueda+'%' OR Nombre_Ruta LIKE '%'+@parametroBusqueda+'%'OR @parametroBusqueda = ''
END
GO
