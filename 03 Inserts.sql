USE 5to_grandt67;

-- Equipos
INSERT INTO Equipo (idEquipo, equipo) VALUES (1, 'Boca Juniors');
INSERT INTO Equipo (idEquipo, equipo) VALUES (2, 'River Plate');
INSERT INTO Equipo (idEquipo, equipo) VALUES (3, 'Racing Club');
INSERT INTO Equipo (idEquipo, equipo) VALUES (4, 'Independiente');

-- Jugadores
INSERT INTO Jugador (idEquipo, nombre, apellido, apodo, fechaNacimiento, cotizacion, posicion) VALUES
(2, 'Franco', 'Armani', 'Pulpo', '1986-10-16', 5000000.00, 'Arquero'),
(1, 'Sergio', 'Romero', 'Chiquito', '1987-02-22', 4500000.00, 'Arquero'),
(3, 'Gabriel', 'Arias', 'Gabi', '1987-09-13', 4000000.00, 'Arquero'),
(1, 'Marcos', 'Rojo', 'Capitan', '1990-03-20', 4500000.00, 'Defensor'),
(1, 'Luis', 'Advincula', 'Rayo', '1990-03-02', 4000000.00, 'Defensor'),
(2, 'German', 'Pezzella', 'German', '1991-06-27', 7500000.00, 'Defensor'),
(2, 'Marcos', 'Acuna', 'Huevo', '1991-10-28', 8000000.00, 'Defensor'),
(4, 'Kevin', 'Lomonaco', 'Lomonaco', '2002-01-08', 6000000.00, 'Defensor'),
(1, 'Kevin', 'Zeno', 'Zeno', '2001-06-14', 8500000.00, 'Mediocampista'),
(2, 'Franco', 'Mastantuono', 'Mastan', '2007-08-14', 15000000.00, 'Mediocampista'),
(3, 'Juan', 'Quintero', 'Juanfer', '1993-01-18', 9000000.00, 'Mediocampista'),
(4, 'Felipe', 'Loyola', 'Pipe', '2000-11-09', 7000000.00, 'Mediocampista'),
(1, 'Edinson', 'Cavani', 'Matador', '1987-02-14', 10000000.00, 'Delantero'),
(2, 'Miguel', 'Borja', 'Colibri', '1993-01-26', 11000000.00, 'Delantero'),
(3, 'Adrian', 'Martinez', 'Maravilla', '1992-07-07', 9500000.00, 'Delantero'),
(4, 'Gabriel', 'Avalos', 'Gabi', '1990-10-12', 6500000.00, 'Delantero');

-- Usuarios
INSERT INTO Usuario (nombre, apellido, email, fechaNacimiento, pass, administrador) VALUES
('Admin', 'Sistema', 'admin@grandt.com', '1990-01-01', '8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', 1),
('Juan', 'Perez', 'juan.perez@email.com', '2000-05-15', '8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', 0);

-- Plantilla
INSERT INTO Plantilla (idUsuario) VALUES (2);

-- PlantillaJugador
INSERT INTO PlantillaJugador (idPlantilla, idJugador, esTitular) VALUES
(1, 1, 1),
(1, 4, 1),
(1, 5, 1),
(1, 6, 1),
(1, 7, 1),
(1, 9, 1),
(1, 10, 1),
(1, 11, 1),
(1, 12, 1),
(1, 13, 1),
(1, 14, 1),
(1, 2, 0),
(1, 15, 0);

-- Puntuacion
INSERT INTO Puntuacion (idJugador, numFecha, nota) VALUES
(1, 1, 8.0),
(4, 1, 6.5),
(5, 1, 7.0),
(6, 1, 7.5),
(7, 1, 8.0),
(9, 1, 8.5),
(10, 1, 9.0),
(11, 1, 7.5),
(12, 1, 6.5),
(13, 1, 9.5),
(14, 1, 8.5);