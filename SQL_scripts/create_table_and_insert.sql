CREATE TABLE IF NOT EXISTS `person` (
	`id` bigint NOT NULL auto_increment,
  `address` varchar(100) NOT NULL,
  `first_name` varchar(80) NOT NULL,
  `gender` varchar(6) NOT NULL,
  `last_name` varchar(80) NOT NULL,
  PRIMARY KEY (`id`)
);

INSERT INTO `person`(address, first_name, gender, last_name) VALUES('São Paulo - Brasil','Ayrton','Male','Senna') ;
