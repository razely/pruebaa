USE 5to_grandt67;

-- Crear el usuario que va a usar la API para conectarse a la base de datos
CREATE USER IF NOT EXISTS 'grandtvot'@'localhost' IDENTIFIED BY 'H@lo1233';
GRANT SELECT, INSERT, UPDATE, DELETE ON 5to_grandt67.* TO 'grandtvot'@'localhost';

-- Crear el usuario administrador para el programa de escritorio
CREATE USER IF NOT EXISTS 'grandt.admin'@'localhost' IDENTIFIED BY 'AdminPass67!';
-- Darle todos los permisos al administrador sobre nuestra base de datos
GRANT ALL PRIVILEGES ON 5to_grandt67.* TO 'grandt.admin'@'localhost';

FLUSH PRIVILEGES;