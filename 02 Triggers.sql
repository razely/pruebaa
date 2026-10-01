USE 5to_grandt67;
DELIMITER ##

CREATE TRIGGER LimiteJugadores BEFORE INSERT ON PlantillaJugador
FOR EACH ROW
BEGIN
    DECLARE cant INT;

    SELECT COUNT(*) INTO cant
    FROM PlantillaJugador
    WHERE idPlantilla = NEW.idPlantilla;

    IF cant >= 20 THEN
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'Error: la plantilla ya tiene 20 jugadores';
    END IF;
END ##

DELIMITER ;