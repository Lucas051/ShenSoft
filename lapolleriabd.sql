-- phpMyAdmin SQL Dump
-- version 4.7.9
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1:3306
-- Tiempo de generación: 31-10-2018 a las 21:26:13
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
-- Base de datos: `lapolleriabd`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `clientes`
--

DROP TABLE IF EXISTS `clientes`;
CREATE TABLE IF NOT EXISTS `clientes` (
  `num_cliente` int(11) NOT NULL AUTO_INCREMENT,
  `CI` int(11) NOT NULL,
  `nombre_cliente` varchar(50) DEFAULT NULL,
  `direccion_c` varchar(50) DEFAULT NULL,
  `tel_c` varchar(50) DEFAULT NULL,
  `saldo_c` int(11) DEFAULT '0',
  PRIMARY KEY (`num_cliente`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `clientes`
--

INSERT INTO `clientes` (`num_cliente`, `CI`, `nombre_cliente`, `direccion_c`, `tel_c`, `saldo_c`) VALUES
(2, 45874599, 'Guillermo Lopez', 'Lacalle 145', '47354879', 0),
(3, 50558745, 'Juan Carlos', 'Artigas 123', '47345654', 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `facturas`
--

DROP TABLE IF EXISTS `facturas`;
CREATE TABLE IF NOT EXISTS `facturas` (
  `n_factura` int(11) NOT NULL AUTO_INCREMENT,
  `fecha` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `monto` int(11) NOT NULL,
  `forma_de_pago` varchar(30) DEFAULT NULL,
  `num_cliente` int(11) NOT NULL,
  `id_vendedor` int(11) NOT NULL,
  PRIMARY KEY (`n_factura`),
  KEY `num_cliente` (`num_cliente`),
  KEY `id_vendedor` (`id_vendedor`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `facturas`
--

INSERT INTO `facturas` (`n_factura`, `fecha`, `monto`, `forma_de_pago`, `num_cliente`, `id_vendedor`) VALUES
(2, '2018-10-30 15:20:35', 1000, 'Contado', 2, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `factura_prov`
--

DROP TABLE IF EXISTS `factura_prov`;
CREATE TABLE IF NOT EXISTS `factura_prov` (
  `n_factura_prov` int(11) NOT NULL AUTO_INCREMENT,
  `fecha_p` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `num_prov` int(11) NOT NULL,
  `monto` int(11) NOT NULL,
  `forma_de_pago` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`n_factura_prov`),
  KEY `num_prov` (`num_prov`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `factura_prov`
--

INSERT INTO `factura_prov` (`n_factura_prov`, `fecha_p`, `num_prov`, `monto`, `forma_de_pago`) VALUES
(2, '2018-10-29 23:47:17', 6, 0, 'Contado'),
(3, '2018-10-29 23:56:38', 5, 0, 'Contado'),
(4, '2018-10-30 00:07:54', 6, 0, 'Contado'),
(5, '2018-10-30 00:08:00', 6, 0, 'Contado'),
(6, '2018-10-30 00:08:04', 5, 0, 'Contado'),
(7, '2018-10-30 00:08:15', 5, 1200, 'Crédito'),
(8, '2018-10-30 00:08:33', 5, 1000, 'Contado'),
(9, '2018-10-30 00:08:44', 5, 800, 'Crédito'),
(10, '2018-10-30 00:10:55', 5, 200, 'Crédito');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `genera`
--

DROP TABLE IF EXISTS `genera`;
CREATE TABLE IF NOT EXISTS `genera` (
  `n_factura` int(11) NOT NULL,
  `precio_v` int(11) NOT NULL,
  `cantidad` int(11) NOT NULL,
  `descripcion` varchar(80) DEFAULT NULL,
  `cod_producto` int(11) NOT NULL,
  KEY `n_factura` (`n_factura`),
  KEY `cod_producto` (`cod_producto`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `genera`
--

INSERT INTO `genera` (`n_factura`, `precio_v`, `cantidad`, `descripcion`, `cod_producto`) VALUES
(2, 100, 10, 'Alitas', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `generansf`
--

DROP TABLE IF EXISTS `generansf`;
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

DROP TABLE IF EXISTS `pagos_clientes`;
CREATE TABLE IF NOT EXISTS `pagos_clientes` (
  `num_recibo_c` int(11) NOT NULL AUTO_INCREMENT,
  `fecha` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `num_cliente` int(11) NOT NULL,
  `importe` int(11) NOT NULL,
  PRIMARY KEY (`num_recibo_c`),
  KEY `num_cliente` (`num_cliente`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `pagos_clientes`
--

INSERT INTO `pagos_clientes` (`num_recibo_c`, `fecha`, `num_cliente`, `importe`) VALUES
(2, '2018-10-30 01:36:46', 2, 800);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pagos_prov`
--

DROP TABLE IF EXISTS `pagos_prov`;
CREATE TABLE IF NOT EXISTS `pagos_prov` (
  `num_recibo_p` int(11) NOT NULL AUTO_INCREMENT,
  `fecha` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `importe` int(11) NOT NULL,
  `num_prov` int(11) NOT NULL,
  `numero_recibo_fisico_p` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`num_recibo_p`),
  KEY `num_prov` (`num_prov`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `pagos_prov`
--

INSERT INTO `pagos_prov` (`num_recibo_p`, `fecha`, `importe`, `num_prov`, `numero_recibo_fisico_p`) VALUES
(1, '2018-10-30 00:58:58', 1000, 5, 'A23412'),
(2, '2018-10-30 00:59:27', 500, 5, 'A45532'),
(3, '2018-10-30 01:48:14', 500, 5, 'B34231');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `proveedores`
--

DROP TABLE IF EXISTS `proveedores`;
CREATE TABLE IF NOT EXISTS `proveedores` (
  `num_prov` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_prov` varchar(50) DEFAULT NULL,
  `tel_p` varchar(50) DEFAULT NULL,
  `direccion_p` varchar(50) DEFAULT NULL,
  `saldo_p` int(11) DEFAULT '0',
  PRIMARY KEY (`num_prov`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `proveedores`
--

INSERT INTO `proveedores` (`num_prov`, `nombre_prov`, `tel_p`, `direccion_p`, `saldo_p`) VALUES
(5, 'PollosDeft', '47354689', 'Ruta 3 km. 8', 0),
(6, 'MeatCon', '098115216 - 47518421', 'Saravia 56 (Artigas)', 0),
(7, 'Frigorifico La Caballada', '47324587', 'Ruta 31 km. 20', 0),
(8, 'Frigorifico Las Piedras', '47354689', 'Ruta 4 km. 20', 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `stock`
--

DROP TABLE IF EXISTS `stock`;
CREATE TABLE IF NOT EXISTS `stock` (
  `cod_producto` int(11) NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(80) DEFAULT NULL,
  `cantidad` int(11) NOT NULL,
  `precio_costo` int(11) NOT NULL,
  `precio_v_stock` int(11) NOT NULL,
  `n_factura_prov` int(11) NOT NULL,
  PRIMARY KEY (`cod_producto`),
  KEY `n_factura_prov` (`n_factura_prov`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `stock`
--

INSERT INTO `stock` (`cod_producto`, `descripcion`, `cantidad`, `precio_costo`, `precio_v_stock`, `n_factura_prov`) VALUES
(1, 'Alitas', 1, 120, 250, 7),
(2, 'Milanesas de Carne', 10, 200, 300, 7),
(3, 'Milanesas de Pollo', 5, 200, 220, 8),
(4, 'Milanesas de Jamon y Queso', 10, 150, 180, 9);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
CREATE TABLE IF NOT EXISTS `usuarios` (
  `user` varchar(50) NOT NULL,
  `pass` varchar(128) DEFAULT NULL,
  PRIMARY KEY (`user`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`user`, `pass`) VALUES
('Administrador', '1e7f0832d6a3c62d1cddc1d271553e567a99506803feec02c2c28e379fcd272f'),
('Dueños', 'b3a8e0e1f9ab1bfe3a36f231f676f78bb30a519d2b21e6c530c0eee8ebb4a5d0'),
('Gerentes', 'b22eb34537f6f6753da6e0dc05713be0ccc35ef12dae0f6bf19b5206d373af33'),
('Empleado', 'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `vendedores`
--

DROP TABLE IF EXISTS `vendedores`;
CREATE TABLE IF NOT EXISTS `vendedores` (
  `id_vendedor` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_vendedor` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`id_vendedor`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `vendedores`
--

INSERT INTO `vendedores` (`id_vendedor`, `nombre_vendedor`) VALUES
(1, 'Lucas'),
(2, 'Pio'),
(3, 'Coco');

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `facturas`
--
ALTER TABLE `facturas`
  ADD CONSTRAINT `facturas_ibfk_1` FOREIGN KEY (`num_cliente`) REFERENCES `clientes` (`num_cliente`),
  ADD CONSTRAINT `facturas_ibfk_2` FOREIGN KEY (`id_vendedor`) REFERENCES `vendedores` (`id_vendedor`);

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
-- Filtros para la tabla `generansf`
--
ALTER TABLE `generansf`
  ADD CONSTRAINT `generansf_ibfk_1` FOREIGN KEY (`cod_producto`) REFERENCES `stock` (`cod_producto`),
  ADD CONSTRAINT `generansf_ibfk_2` FOREIGN KEY (`n_factura_prov`) REFERENCES `factura_prov` (`n_factura_prov`);

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
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
