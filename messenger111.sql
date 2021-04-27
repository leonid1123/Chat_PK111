-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1
-- Время создания: Апр 12 2021 г., 08:06
-- Версия сервера: 10.4.16-MariaDB
-- Версия PHP: 7.4.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `messenger111`
--

-- --------------------------------------------------------

--
-- Структура таблицы `messages`
--

CREATE TABLE `messages` (
  `id` int(11) NOT NULL,
  `author` varchar(50) NOT NULL,
  `timeStamp` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `msg` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Дамп данных таблицы `messages`
--

INSERT INTO `messages` (`id`, `author`, `timeStamp`, `msg`) VALUES
(1, 'Leo', '2021-04-05 08:17:21', 'сообщение тут'),
(5, 'Leo', '2021-04-08 10:57:38', 'еще сообщение'),
(6, 'Leo', '2021-04-08 10:58:44', 'еще сообщение'),
(7, 'Misha', '2021-04-08 12:49:34', 'Приветики))))'),
(8, 'Leo', '2021-04-08 13:25:34', 'еще сообщение'),
(9, 'Leo', '2021-04-08 13:42:02', 'sdgcfvbyujrytyiyuvch'),
(10, 'Leo', '2021-04-08 13:51:35', 'mgfbffv'),
(11, 'Leo', '2021-04-08 13:52:06', 'drop table'),
(12, 'Leo', '2021-04-08 13:52:15', 'drop table plz'),
(13, 'Leo', '2021-04-08 13:52:21', 'drop table peeeeeeese\r\n'),
(14, 'Leo', '2021-04-08 13:52:31', 'drop table fack\r\n'),
(15, 'Leo', '2021-04-09 06:08:49', '@myMessage'),
(16, 'Leo', '2021-04-09 06:11:20', '786532000'),
(17, 'Leo', '2021-04-09 06:44:30', 'nbvmnb'),
(18, 'Leo', '2021-04-09 06:44:54', '121321321'),
(19, 'Leo', '2021-04-09 06:45:09', 'чатик тут\r\n'),
(20, 'Leo', '2021-04-09 06:45:26', 'лдцчртспкгнп цгнп\r\n'),
(21, 'Leo', '2021-04-09 06:45:29', 'чяспарт ркеып\r\n'),
(22, 'Leo', '2021-04-09 06:45:33', 'чсч смяапвн \r\n'),
(23, 'Leo', '2021-04-09 07:16:35', 'aedsdvb'),
(24, 'Leo', '2021-04-09 07:16:36', 'aedsdvb'),
(25, 'Leo', '2021-04-09 07:16:36', 'aedsdvb'),
(26, 'Leo', '2021-04-09 07:16:36', 'aedsdvb'),
(27, 'Leo', '2021-04-09 07:16:36', 'aedsdvb'),
(28, 'Leo', '2021-04-09 07:16:37', 'aedsdvb'),
(29, 'Leo', '2021-04-09 07:16:37', 'aedsdvb'),
(30, 'Leo', '2021-04-09 07:16:37', 'aedsdvb'),
(31, 'Leo', '2021-04-09 07:16:37', 'aedsdvb'),
(32, 'Leo', '2021-04-09 07:16:37', 'aedsdvb'),
(33, 'Leo', '2021-04-09 07:16:38', 'aedsdvb'),
(34, 'Leo', '2021-04-09 07:16:38', 'aedsdvb'),
(35, 'Leo', '2021-04-09 07:16:38', 'aedsdvb'),
(36, 'Leo', '2021-04-09 07:16:38', 'aedsdvb'),
(37, 'Leo', '2021-04-09 07:16:38', 'aedsdvb'),
(38, 'Leo', '2021-04-09 07:16:39', 'aedsdvb'),
(39, 'Leo', '2021-04-09 08:13:35', '123'),
(40, 'Leo', '2021-04-09 08:14:10', '1234'),
(41, 'Leo', '2021-04-09 08:14:20', '12345'),
(42, 'Leo', '2021-04-09 08:14:32', '123456'),
(43, 'Leo', '2021-04-09 08:17:37', 'xfcdvfbh'),
(44, 'Leo', '2021-04-09 08:17:46', 'xcn fd sh');

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `messages`
--
ALTER TABLE `messages`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `messages`
--
ALTER TABLE `messages`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=45;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
