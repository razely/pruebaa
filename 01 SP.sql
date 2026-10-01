USE 5to_grandt67;
DELIMITER ##

CREATE PROCEDURE PuntajeFecha( IN id_plantilla INT,
							   IN fecha INT)
BEGIN
    SELECT SUM(Puntuacion.nota) AS puntajeTotal
    FROM PlantillaJugador
    INNER JOIN Puntuacion ON PlantillaJugador.idJugador = Puntuacion.idJugador
    WHERE PlantillaJugador.idPlantilla = id_plantilla
      AND PlantillaJugador.esTitular = 1
      AND Puntuacion.numFecha = fecha;
END ##

CREATE PROCEDURE ObtenerPlantilla( IN id_plantilla INT)
BEGIN
    SELECT Jugador.idJugador, Jugador.nombre, Jugador.apellido, Jugador.posicion, Jugador.cotizacion, PlantillaJugador.esTitular
    FROM PlantillaJugador
    INNER JOIN Jugador ON PlantillaJugador.idJugador = Jugador.idJugador
    WHERE PlantillaJugador.idPlantilla = id_plantilla;
END ##

DELIMITER ;