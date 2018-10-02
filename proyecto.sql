-- phpMyAdmin SQL Dump
-- version 3.5.1
-- http://www.phpmyadmin.net
--
-- Servidor: localhost
-- Tiempo de generación: 02-10-2018 a las 15:08:50
-- Versión del servidor: 5.5.24-log
-- Versión de PHP: 5.4.3

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de datos: `proyecto`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `clientes`
--

CREATE TABLE IF NOT EXISTS `clientes` (
  `num_cliente` int(11) NOT NULL AUTO_INCREMENT,
  `CI` int(11) NOT NULL,
  `nombre_cliente` varchar(50) DEFAULT NULL,
  `direccion_c` varchar(50) DEFAULT NULL,
  `tel_c` varchar(50) DEFAULT NULL,
  `saldo_c` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`num_cliente`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `facturas`
--

CREATE TABLE IF NOT EXISTS `facturas` (
  `n_factura` int(11) NOT NULL AUTO_INCREMENT,
  `fecha` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `monto` int(11) NOT NULL,
  `num_cliente` int(11) NOT NULL,
  PRIMARY KEY (`n_factura`),
  KEY `num_cliente` (`num_cliente`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `factura_prov`
--

CREATE TABLE IF NOT EXISTS `factura_prov` (
  `n_factura_prov` int(11) NOT NULL AUTO_INCREMENT,
  `fecha` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `monto` int(11) NOT NULL,
  `num_prov` int(11) NOT NULL,
  PRIMARY KEY (`n_factura_prov`),
  KEY `num_prov` (`num_prov`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `genera`
--

CREATE TABLE IF NOT EXISTS `genera` (
  `n_factura` int(11) NOT NULL,
  `precio_v` int(11) NOT NULL,
  `cantidad` int(11) NOT NULL,
  `cod_producto` int(11) NOT NULL,
  KEY `cod_producto` (`cod_producto`),
  KEY `n_factura` (`n_factura`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `generansf`
--

CREATE TABLE IF NOT EXISTS `generansf` (
  `cod_producto` int(11) NOT NULL,
  `n_factura_prov` int(11) NOT NULL,
  `precio` int(11) NOT NULL,
  `cantidad_stock` int(11) NOT NULL,
  KEY `cod_producto` (`cod_producto`),
  KEY `n_factura_prov` (`n_factura_prov`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pagos_clientes`
--

CREATE TABLE IF NOT EXISTS `pagos_clientes` (
  `num_recibo_c` int(11) NOT NULL AUTO_INCREMENT,
  `fecha` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `importe` int(11) NOT NULL,
  `num_cliente` int(11) NOT NULL,
  PRIMARY KEY (`num_recibo_c`),
  KEY `num_cliente` (`num_cliente`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pagos_prov`
--

CREATE TABLE IF NOT EXISTS `pagos_prov` (
  `num_recibo_p` int(11) NOT NULL AUTO_INCREMENT,
  `fecha` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `importe` int(11) NOT NULL,
  `num_prov` int(11) NOT NULL,
  PRIMARY KEY (`num_recibo_p`),
  KEY `num_prov` (`num_prov`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `proveedores`
--

CREATE TABLE IF NOT EXISTS `proveedores` (
  `num_prov` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_prov` varchar(50) DEFAULT NULL,
  `tel_p` varchar(50) DEFAULT NULL,
  `direccion_p` varchar(50) DEFAULT NULL,
  `saldo_p` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`num_prov`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `stock`
--

CREATE TABLE IF NOT EXISTS `stock` (
  `cod_producto` int(11) NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(50) DEFAULT NULL,
  `precio_costo` int(11) NOT NULL,
  `cantidad` int(11) NOT NULL,
  `precio_v_stock` int(11) NOT NULL,
  `n_factura_prov` int(11) NOT NULL,
  PRIMARY KEY (`cod_producto`),
  KEY `n_factura_prov` (`n_factura_prov`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

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
  ADD CONSTRAINT `genera_ibfk_2` FOREIGN KEY (`n_factura`) REFERENCES `facturas` (`n_factura`),
  ADD CONSTRAINT `genera_ibfk_1` FOREIGN KEY (`cod_producto`) REFERENCES `stock` (`cod_producto`);

--
-- Filtros para la tabla `generansf`
--
ALTER TABLE `generansf`
  ADD CONSTRAINT `generansf_ibfk_2` FOREIGN KEY (`n_factura_prov`) REFERENCES `factura_prov` (`n_factura_prov`),
  ADD CONSTRAINT `generansf_ibfk_1` FOREIGN KEY (`cod_producto`) REFERENCES `stock` (`cod_producto`);

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
  ADD CONSTRAINT `stock_ibfk_1` FOREIGN KEY (`n_factura_prov`) REFERENCES `factura_prov` (`n_factura_prov`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
