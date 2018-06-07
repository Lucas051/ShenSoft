-- phpMyAdmin SQL Dump
-- version 4.7.9
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1:3306
-- Tiempo de generación: 07-06-2018 a las 20:59:08
-- Versión del servidor: 5.7.21
-- Versión de PHP: 5.6.35

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `proyecto`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `clientes`
--

DROP TABLE IF EXISTS `clientes`;
CREATE TABLE IF NOT EXISTS `clientes` (
  `num_cliente` int(11) NOT NULL AUTO_INCREMENT,
  `CI` int(11) NOT NULL,
  `nombre_cliente` varchar(40) DEFAULT NULL,
  `saldo_c` int(11) NOT NULL,
  `direccion_c` varchar(40) DEFAULT NULL,
  `tel_c` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`num_cliente`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `facturas`
--

DROP TABLE IF EXISTS `facturas`;
CREATE TABLE IF NOT EXISTS `facturas` (
  `n_factura` int(11) NOT NULL AUTO_INCREMENT,
  `fecha` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `monto` int(11) NOT NULL,
  `num_cliente` int(11) DEFAULT NULL,
  `forma_de_pago` varchar(12) DEFAULT NULL,
  PRIMARY KEY (`n_factura`),
  KEY `num_cliente` (`num_cliente`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `factura_prov`
--

DROP TABLE IF EXISTS `factura_prov`;
CREATE TABLE IF NOT EXISTS `factura_prov` (
  `n_factura_prov` int(11) NOT NULL AUTO_INCREMENT,
  `fecha` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `monto` int(11) NOT NULL,
  `num_prov` int(11) DEFAULT NULL,
  PRIMARY KEY (`n_factura_prov`),
  KEY `num_prov` (`num_prov`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `genera`
--

DROP TABLE IF EXISTS `genera`;
CREATE TABLE IF NOT EXISTS `genera` (
  `n_factura` int(11) DEFAULT NULL,
  `precio_v` int(11) NOT NULL,
  `cantidad` int(11) NOT NULL,
  `cod_producto` int(11) DEFAULT NULL,
  KEY `n_factura` (`n_factura`),
  KEY `cod_producto` (`cod_producto`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pagos_clientes`
--

DROP TABLE IF EXISTS `pagos_clientes`;
CREATE TABLE IF NOT EXISTS `pagos_clientes` (
  `num_recibo_c` int(11) NOT NULL AUTO_INCREMENT,
  `fecha` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `importe` int(11) NOT NULL,
  `num_cliente` int(11) DEFAULT NULL,
  PRIMARY KEY (`num_recibo_c`),
  KEY `num_cliente` (`num_cliente`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pagos_prov`
--

DROP TABLE IF EXISTS `pagos_prov`;
CREATE TABLE IF NOT EXISTS `pagos_prov` (
  `n_recibo_prov` int(11) NOT NULL AUTO_INCREMENT,
  `fecha` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `importe` int(11) NOT NULL,
  `num_prov` int(11) DEFAULT NULL,
  PRIMARY KEY (`n_recibo_prov`),
  KEY `num_prov` (`num_prov`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `proveedores`
--

DROP TABLE IF EXISTS `proveedores`;
CREATE TABLE IF NOT EXISTS `proveedores` (
  `num_prov` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_prov` varchar(40) DEFAULT NULL,
  `tel_p` varchar(40) DEFAULT NULL,
  `direccion_p` varchar(40) DEFAULT NULL,
  `saldo_p` int(11) NOT NULL,
  PRIMARY KEY (`num_prov`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `stock`
--

DROP TABLE IF EXISTS `stock`;
CREATE TABLE IF NOT EXISTS `stock` (
  `cod_producto` int(11) NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(80) DEFAULT NULL,
  `cantidad` varchar(10) DEFAULT NULL,
  `precio_costo` int(11) NOT NULL,
  `precio_v_stock` int(11) NOT NULL,
  `num_prov` int(11) DEFAULT NULL,
  PRIMARY KEY (`cod_producto`),
  KEY `num_prov` (`num_prov`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `stock`
--

INSERT INTO `stock` (`cod_producto`, `descripcion`, `cantidad`, `precio_costo`, `precio_v_stock`, `num_prov`) VALUES
(1, 'asdasd', NULL, 321, 444, NULL),
(2, 'asdasd', '3', 233, 4444, NULL),
(3, 'Hola anduvo', '23', 234, 3333, NULL);

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `facturas`
--
ALTER TABLE `facturas`
  ADD CONSTRAINT `facturas_ibfk_1` FOREIGN KEY (`num_cliente`) REFERENCES `clientes` (`num_cliente`);

--
-- Filtros para la tabla `factura_prov`
--
ALTER TABLE `factura_prov`
  ADD CONSTRAINT `factura_prov_ibfk_1` FOREIGN KEY (`num_prov`) REFERENCES `proveedores` (`num_prov`);

--
-- Filtros para la tabla `genera`
--
ALTER TABLE `genera`
  ADD CONSTRAINT `genera_ibfk_1` FOREIGN KEY (`n_factura`) REFERENCES `facturas` (`n_factura`),
  ADD CONSTRAINT `genera_ibfk_2` FOREIGN KEY (`cod_producto`) REFERENCES `stock` (`cod_producto`);

--
-- Filtros para la tabla `pagos_clientes`
--
ALTER TABLE `pagos_clientes`
  ADD CONSTRAINT `pagos_clientes_ibfk_1` FOREIGN KEY (`num_cliente`) REFERENCES `clientes` (`num_cliente`);

--
-- Filtros para la tabla `pagos_prov`
--
ALTER TABLE `pagos_prov`
  ADD CONSTRAINT `pagos_prov_ibfk_1` FOREIGN KEY (`num_prov`) REFERENCES `proveedores` (`num_prov`);

--
-- Filtros para la tabla `stock`
--
ALTER TABLE `stock`
  ADD CONSTRAINT `stock_ibfk_1` FOREIGN KEY (`num_prov`) REFERENCES `proveedores` (`num_prov`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
