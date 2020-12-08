
CREATE DATABASE  IF NOT EXISTS `ProtonDatabase`;

USE `ProtonDatabase`;

/*Table structure for table `people` */

DROP TABLE IF EXISTS `Template`;

CREATE TABLE `Template` (
  `name` text DEFAULT NULL,
  `country` text DEFAULT NULL,
  `age` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


