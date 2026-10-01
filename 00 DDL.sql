CREATE DATABASE IF NOT EXISTS 5to_grandt67;
USE 5to_grandt67;

-- Tabla Equipo
CREATE TABLE Equipo (
idEquipo INT AUTO_INCREMENT PRIMARY KEY,
equipo VARCHAR (45) NOT NULL UNIQUE
);

-- Tabla Jugador
CREATE TABLE Jugador (
idJugador INT AUTO_INCREMENT PRIMARY KEY,
idEquipo INT NOT NULL,
nombre VARCHAR (45) NOT NULL,
apellido VARCHAR (45) NOT NULL,
apodo VARCHAR (45),
fechaNacimiento DATE NOT NULL,
cotizacion DECIMAL (10, 2),
posicion VARCHAR (15),
FOREIGN KEY (idEquipo) REFERENCES Equipo(idEquipo)
);

-- Tabla Usuario
CREATE TABLE Usuario (
idUsuario INT AUTO_INCREMENT PRIMARY KEY,
nombre VARCHAR (45) NOT NULL,
apellido VARCHAR (45) NOT NULL,
email VARCHAR (100) NOT NULL UNIQUE,
fechaNacimiento DATE NOT NULL,
pass CHAR (64) NOT NULL,
administrador BOOLEAN DEFAULT FALSE 
);

-- Tabla Plantilla
CREATE TABLE Plantilla (
idPlantilla INT AUTO_INCREMENT PRIMARY KEY,
idUsuario INT NOT NULL,
FOREIGN KEY  (idUsuario) REFERENCES Usuario (idUsuario)
);

-- Tabla para titulares y suplentes
CREATE TABLE PlantillaJugador (
idPlantilla INT,
idJugador INT,
esTitular BOOLEAN NOT NULL DEFAULT TRUE,
PRIMARY KEY (idPlantilla, idJugador),
FOREIGN KEY (idJugador) REFERENCES Jugador (idJugador) ON DELETE CASCADE,
FOREIGN KEY (idPlantilla) REFERENCES Plantilla (idPlantilla) ON DELETE CASCADE
);

-- Tabla puntuacion
CREATE TABLE Puntuacion (
idPuntuacion INT AUTO_INCREMENT PRIMARY KEY,
idJugador INT NOT NULL,
numFecha INT CHECK (numFecha > 0 AND numfecha < 50) NOT NULL,
nota DECIMAL (3,1) CHECK (nota BETWEEN 1.0 AND 10.0) NOT NULL,
UNIQUE (idJugador, numFecha),
FOREIGN KEY (idJugador) REFERENCES Jugador (idJugador) ON DELETE CASCADE
);