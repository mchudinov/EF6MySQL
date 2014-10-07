CREATE DATABASE `Mydatabase` /*!40100 DEFAULT CHARACTER SET utf8 */;
use `Mydatabase`;
CREATE TABLE `MyModel` (
  `Id` char(36) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `Value` varchar(300) DEFAULT NULL,
  `DateTime` datetime NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
