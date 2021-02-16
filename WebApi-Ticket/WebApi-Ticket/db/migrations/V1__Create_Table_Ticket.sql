CREATE TABLE IF NOT EXISTS `ticket` (
  `id` bigint NOT NULL AUTO_INCREMENT,
  `descricao` longtext,
  `autor` longtext,
  `data` datetime(6) DEFAULT NULL,
  PRIMARY KEY (`id`)
);