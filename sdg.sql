-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 07-07-2025 a las 18:05:19
-- Versión del servidor: 10.4.32-MariaDB
-- Versión de PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `sdg`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `caja`
--

CREATE TABLE `caja` (
  `idCaja` int(11) NOT NULL,
  `nombre` varchar(30) NOT NULL,
  `efectivo` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `caja`
--

INSERT INTO `caja` (`idCaja`, `nombre`, `efectivo`) VALUES
(1, 'Caja Principal N°1', 28396.66),
(2, 'Caja Secundaria', 216100.00);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `categoria`
--

CREATE TABLE `categoria` (
  `idCategoria` int(11) NOT NULL,
  `nombreCat` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `categoria`
--

INSERT INTO `categoria` (`idCategoria`, `nombreCat`) VALUES
(1, 'Monitor'),
(2, 'Gabinete'),
(3, 'Fuente'),
(4, 'RAM');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cliente`
--

CREATE TABLE `cliente` (
  `idCliente` int(11) NOT NULL,
  `nombre` varchar(30) NOT NULL,
  `apellido` varchar(30) NOT NULL,
  `dni` varchar(10) NOT NULL,
  `fechaNacimiento` date NOT NULL,
  `nroTelefono` varchar(20) NOT NULL,
  `email` varchar(50) NOT NULL,
  `direccion` varchar(40) NOT NULL,
  `localidad` varchar(40) NOT NULL,
  `idProvincia` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `cliente`
--

INSERT INTO `cliente` (`idCliente`, `nombre`, `apellido`, `dni`, `fechaNacimiento`, `nroTelefono`, `email`, `direccion`, `localidad`, `idProvincia`) VALUES
(1, 'Jeremias', 'Rinaldi', '35452123', '1995-07-23', '1134234223', 'jererinaldi@mail.es', 'Balbin 8900', 'San Andrés', 2),
(2, 'Julio', 'Perez', '25872834', '1976-10-13', '158723876', 'jperez@gmail.com', 'Portugal 466', 'W. Morrris', 2),
(4, 'Fernando', 'Lucero', '40111000', '1998-09-05', '1523652364', 'ferlucero@gmail.com', 'Costa Rica 2342', 'Saavedra', 2);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `compra`
--

CREATE TABLE `compra` (
  `idCompra` int(11) NOT NULL,
  `fechaCompra` date NOT NULL,
  `horaCompra` time NOT NULL,
  `importeTotal` decimal(10,2) NOT NULL,
  `idPersonal` int(11) NOT NULL,
  `idProveedor` int(11) NOT NULL,
  `idCaja` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `compra`
--

INSERT INTO `compra` (`idCompra`, `fechaCompra`, `horaCompra`, `importeTotal`, `idPersonal`, `idProveedor`, `idCaja`) VALUES
(1, '2025-07-07', '12:08:14', 372004.00, 1, 2, 1),
(2, '2025-07-07', '12:36:35', 76000.00, 1, 1, 2);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detallecompra`
--

CREATE TABLE `detallecompra` (
  `idDetalleCompra` int(11) NOT NULL,
  `cantidad` int(11) NOT NULL,
  `precioCompra` decimal(10,2) NOT NULL,
  `total` decimal(10,2) NOT NULL,
  `descripcion` varchar(100) NOT NULL,
  `idProducto` int(11) NOT NULL,
  `idCompra` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `detallecompra`
--

INSERT INTO `detallecompra` (`idDetalleCompra`, `cantidad`, `precioCompra`, `total`, `descripcion`, `idProducto`, `idCompra`) VALUES
(1, 1, 76000.00, 76000.00, 'XPG 230G1', 19, 2);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalleventa`
--

CREATE TABLE `detalleventa` (
  `idDetalleVenta` int(11) NOT NULL,
  `cantidad` int(11) NOT NULL,
  `precioVenta` decimal(10,2) NOT NULL,
  `total` decimal(10,2) NOT NULL,
  `descripcion` varchar(100) NOT NULL,
  `idVenta` int(11) NOT NULL,
  `idProducto` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `detalleventa`
--

INSERT INTO `detalleventa` (`idDetalleVenta`, `cantidad`, `precioVenta`, `total`, `descripcion`, `idVenta`, `idProducto`) VALUES
(1, 1, 130000.00, 130000.00, 'Samsung S24F D602', 9, 1),
(2, 2, 130000.00, 260000.00, 'Corsair CX750', 9, 7),
(3, 2, 96000.00, 192000.00, 'XPG 230G1', 10, 19);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `marca`
--

CREATE TABLE `marca` (
  `idMarca` int(11) NOT NULL,
  `nombreMarca` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `marca`
--

INSERT INTO `marca` (`idMarca`, `nombreMarca`) VALUES
(1, 'ThermalTake'),
(2, 'Cooler Master'),
(4, 'Corsair'),
(5, 'LG'),
(12, 'Gigabyte'),
(13, 'Samsung'),
(14, 'Kingston'),
(15, 'XPG');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `personal`
--

CREATE TABLE `personal` (
  `IdPersonal` int(11) NOT NULL,
  `nombre` varchar(30) NOT NULL,
  `apellido` varchar(30) NOT NULL,
  `dni` varchar(10) NOT NULL,
  `fechaNacimiento` date NOT NULL,
  `nroTelefono` varchar(20) NOT NULL,
  `email` varchar(50) NOT NULL,
  `direccion` varchar(40) NOT NULL,
  `localidad` varchar(40) NOT NULL,
  `idProvincia` int(11) NOT NULL,
  `idRol` int(11) NOT NULL,
  `claveAcceso` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `personal`
--

INSERT INTO `personal` (`IdPersonal`, `nombre`, `apellido`, `dni`, `fechaNacimiento`, `nroTelefono`, `email`, `direccion`, `localidad`, `idProvincia`, `idRol`, `claveAcceso`) VALUES
(1, 'nombre', 'apellido', 'admin', '0000-00-00', '-', '-', '-', '-', 1, 1, 'admin'),
(2, 'Pedro', 'Lopez', '32123450', '1989-02-02', '1143476032', 'pedrolz@gmail.com', 'Francia 345', 'Caseros', 1, 2, 'pedro123'),
(3, 'Lucas', 'Araujo', '41582012', '1999-03-12', '1198325151', 'lucasaraujo@gmail.com', 'Belgica 9888', 'Budge', 1, 3, 'lucas123');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `producto`
--

CREATE TABLE `producto` (
  `idProducto` int(11) NOT NULL,
  `codProducto` varchar(20) NOT NULL,
  `idMarca` int(11) NOT NULL,
  `modelo` varchar(20) NOT NULL,
  `cantidadStock` int(11) NOT NULL,
  `precioCompra` decimal(10,2) NOT NULL,
  `precioVenta` decimal(10,2) NOT NULL,
  `idCategoria` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `producto`
--

INSERT INTO `producto` (`idProducto`, `codProducto`, `idMarca`, `modelo`, `cantidadStock`, `precioCompra`, `precioVenta`, `idCategoria`) VALUES
(1, '4444', 13, 'S24F D602', 9, 120000.00, 130000.00, 1),
(2, '2222', 1, 'S200', 3, 90000.00, 100000.00, 2),
(3, '7676', 4, 'CX650', 9, 95000.00, 115000.00, 3),
(7, '7678', 4, 'CX750', 8, 120000.00, 130000.00, 3),
(8, '2324', 13, 'S27 QHD', 0, 350000.00, 370000.00, 1),
(12, '5596', 2, 'CM24 144Hz', 3, 23001.00, 33001.00, 1),
(15, '5655', 5, 'Thinkverse 24FF', 10, 185000.00, 205000.00, 1),
(16, '8788', 14, 'HyperX 8GB', 7, 27000.00, 35000.00, 4),
(19, '1112', 15, '230G1', 1, 76000.00, 96000.00, 2);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `proveedor`
--

CREATE TABLE `proveedor` (
  `idProveedor` int(11) NOT NULL,
  `razonSocial` varchar(30) NOT NULL,
  `cuil` varchar(20) NOT NULL,
  `mail` varchar(30) NOT NULL,
  `telefono` varchar(15) NOT NULL,
  `paginaWeb` varchar(40) DEFAULT NULL,
  `direccion` varchar(40) NOT NULL,
  `localidad` varchar(40) NOT NULL,
  `idProvincia` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `proveedor`
--

INSERT INTO `proveedor` (`idProveedor`, `razonSocial`, `cuil`, `mail`, `telefono`, `paginaWeb`, `direccion`, `localidad`, `idProvincia`) VALUES
(1, 'Prov1 S.A', '12-32342424-12', 'prov1@mail.es', '123432441', 'prov1.org', 'San cristoblas 4532', 'Tigre', 1),
(2, 'Correa S.A', '33-12312314-77', 'raulc@mcorreasa.com.ar', '54512331131', 'mayoristacorrea.com.ar', 'Lopetegui 333', 'Bella Vista', 8),
(9, 'Remos S.A', '24-432413213-12', 'remos@contact.es', '1132412312', 'remos.ar', 'Luzuriaga 433', 'La angostura', 6);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `provincia`
--

CREATE TABLE `provincia` (
  `idProvincia` int(11) NOT NULL,
  `nombre` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `provincia`
--

INSERT INTO `provincia` (`idProvincia`, `nombre`) VALUES
(1, 'CABA'),
(2, 'Buenos Aires'),
(3, 'Catamarca'),
(4, 'Chaco'),
(5, 'Chubut'),
(6, 'Córdoba'),
(7, 'Corrientes'),
(8, 'Entre Ríos'),
(9, 'Formosa'),
(10, 'Jujuy'),
(11, 'La Pampa'),
(12, 'La Rioja'),
(13, 'Mendoza'),
(14, 'Misiones'),
(15, 'Neuquén'),
(16, 'Río Negro'),
(17, 'Salta'),
(18, 'San Juan'),
(19, 'San Luis'),
(20, 'Santa Cruz'),
(21, 'Santa Fe'),
(22, 'Santiago del Estero'),
(23, 'Tierra del Fuego'),
(24, 'Tucumán');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `rol`
--

CREATE TABLE `rol` (
  `idRol` int(11) NOT NULL,
  `nombreRol` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `rol`
--

INSERT INTO `rol` (`idRol`, `nombreRol`) VALUES
(1, 'Administrador'),
(2, 'Cajero'),
(3, 'Vendedor');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `venta`
--

CREATE TABLE `venta` (
  `idVenta` int(11) NOT NULL,
  `fechaVenta` date NOT NULL,
  `horaVenta` time NOT NULL,
  `importeTotal` decimal(10,2) NOT NULL,
  `importePagado` decimal(10,2) NOT NULL,
  `importeCambio` decimal(10,2) NOT NULL,
  `idPersonal` int(11) NOT NULL,
  `idCliente` int(11) NOT NULL,
  `idCaja` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `venta`
--

INSERT INTO `venta` (`idVenta`, `fechaVenta`, `horaVenta`, `importeTotal`, `importePagado`, `importeCambio`, `idPersonal`, `idCliente`, `idCaja`) VALUES
(1, '0000-00-00', '00:00:00', 1000.00, 1000.00, 0.00, 1, 1, 1),
(2, '2025-07-06', '19:29:08', 100.00, 100.00, 0.00, 1, 1, 1),
(3, '2025-07-06', '20:01:54', 1000.00, 1000.00, 0.00, 1, 1, 1),
(4, '2025-07-06', '20:05:14', 33001.00, 33001.00, 0.00, 1, 2, 1),
(5, '2025-07-06', '20:06:04', 33001.00, 40000.00, 6999.00, 1, 2, 1),
(6, '2025-07-06', '21:13:30', 1000.00, 1000.00, 0.00, 1, 1, 1),
(7, '2025-07-06', '21:16:36', 1000.00, 1000.00, 0.00, 1, 1, 1),
(8, '2025-07-06', '21:16:49', 1000.00, 1000.00, 0.00, 1, 1, 1),
(9, '2025-07-06', '23:46:56', 390000.00, 390000.00, 0.00, 1, 4, 1),
(10, '2025-07-06', '23:53:17', 192000.00, 200000.00, 8000.00, 1, 4, 2);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `caja`
--
ALTER TABLE `caja`
  ADD PRIMARY KEY (`idCaja`);

--
-- Indices de la tabla `categoria`
--
ALTER TABLE `categoria`
  ADD PRIMARY KEY (`idCategoria`);

--
-- Indices de la tabla `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`idCliente`);

--
-- Indices de la tabla `compra`
--
ALTER TABLE `compra`
  ADD PRIMARY KEY (`idCompra`);

--
-- Indices de la tabla `detallecompra`
--
ALTER TABLE `detallecompra`
  ADD PRIMARY KEY (`idDetalleCompra`);

--
-- Indices de la tabla `detalleventa`
--
ALTER TABLE `detalleventa`
  ADD PRIMARY KEY (`idDetalleVenta`);

--
-- Indices de la tabla `marca`
--
ALTER TABLE `marca`
  ADD PRIMARY KEY (`idMarca`);

--
-- Indices de la tabla `personal`
--
ALTER TABLE `personal`
  ADD PRIMARY KEY (`IdPersonal`);

--
-- Indices de la tabla `producto`
--
ALTER TABLE `producto`
  ADD PRIMARY KEY (`idProducto`);

--
-- Indices de la tabla `proveedor`
--
ALTER TABLE `proveedor`
  ADD PRIMARY KEY (`idProveedor`);

--
-- Indices de la tabla `provincia`
--
ALTER TABLE `provincia`
  ADD PRIMARY KEY (`idProvincia`);

--
-- Indices de la tabla `rol`
--
ALTER TABLE `rol`
  ADD PRIMARY KEY (`idRol`);

--
-- Indices de la tabla `venta`
--
ALTER TABLE `venta`
  ADD PRIMARY KEY (`idVenta`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `caja`
--
ALTER TABLE `caja`
  MODIFY `idCaja` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `categoria`
--
ALTER TABLE `categoria`
  MODIFY `idCategoria` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de la tabla `cliente`
--
ALTER TABLE `cliente`
  MODIFY `idCliente` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de la tabla `compra`
--
ALTER TABLE `compra`
  MODIFY `idCompra` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `detallecompra`
--
ALTER TABLE `detallecompra`
  MODIFY `idDetalleCompra` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `detalleventa`
--
ALTER TABLE `detalleventa`
  MODIFY `idDetalleVenta` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `marca`
--
ALTER TABLE `marca`
  MODIFY `idMarca` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT de la tabla `personal`
--
ALTER TABLE `personal`
  MODIFY `IdPersonal` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `producto`
--
ALTER TABLE `producto`
  MODIFY `idProducto` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT de la tabla `proveedor`
--
ALTER TABLE `proveedor`
  MODIFY `idProveedor` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT de la tabla `provincia`
--
ALTER TABLE `provincia`
  MODIFY `idProvincia` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;

--
-- AUTO_INCREMENT de la tabla `rol`
--
ALTER TABLE `rol`
  MODIFY `idRol` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `venta`
--
ALTER TABLE `venta`
  MODIFY `idVenta` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
