DELIMITER $$
CREATE DEFINER=`root`@`%` PROCEDURE `getAll`()
SELECT ingatlanok.id, kategoriak.nev as "kategoria", ingatlanok.leiras, ingatlanok.hirdetesDatuma, ingatlanok.tehermentes, ingatlanok.ar, ingatlanok.kepUrl FROM ingatlanok LEFT JOIN kategoriak ON ingatlanok.kategoria = kategoriak.id$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`%` PROCEDURE `deleteIngatlan`(IN `_id` INT)
IF (SELECT COUNT(*) FROM ingatlanok WHERE id = _id) THEN
	DELETE FROM ingatlanok WHERE id = _id;
    SELECT 1 AS "ok";
ELSE
	SELECT 0 AS "ok";
END IF$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`%` PROCEDURE `createIngatlan`(IN `_kategoria` INT, IN `_leiras` TEXT, IN `_hirdetesDatuma` DATE, IN `_tehermentes` BOOLEAN, IN `_ar` INT, IN `_kepUrl` TEXT)
BEGIN

INSERT INTO ingatlanok (kategoria, leiras, hirdetesDatuma, tehermentes, ar, kepUrl) VALUES (_kategoria, _leiras, _hirdetesDatuma, _tehermentes, _ar, _kepUrl);
SELECT LAST_INSERT_ID() AS id;

END$$
DELIMITER ;
