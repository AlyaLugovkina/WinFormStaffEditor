-- phpMyAdmin SQL Dump
-- version 5.1.2
-- https://www.phpmyadmin.net/
--
-- Хост: localhost:3306
-- Время создания: Июл 16 2024 г., 19:32
-- Версия сервера: 5.7.24
-- Версия PHP: 8.3.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `staff`
--

-- --------------------------------------------------------

--
-- Структура таблицы `staff`
--

CREATE TABLE `staff` (
  `id` int(10) UNSIGNED NOT NULL COMMENT 'уникальный id в базе',
  `name` varchar(100) NOT NULL COMMENT 'Имя',
  `surname` varchar(100) NOT NULL COMMENT 'Фамилия',
  `patronymic` varchar(100) NOT NULL COMMENT 'Отчество',
  `birthDate` date NOT NULL COMMENT 'Дата рождения',
  `snils` varchar(11) NOT NULL COMMENT 'СНИЛС сотрудника(уникален)',
  `position` varchar(100) NOT NULL DEFAULT 'Стажер' COMMENT 'Должность',
  `employmentDate` date NOT NULL COMMENT 'Дата приема на работу'
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `staff`
--

INSERT INTO `staff` (`id`, `name`, `surname`, `patronymic`, `birthDate`, `snils`, `position`, `employmentDate`) VALUES
(1, 'Олег', 'Луньков', 'Олегович', '1996-01-12', '23498762041', 'Уборщик', '2024-03-25'),
(2, 'Эльзара', 'Халилова', 'Меметовна', '1983-03-30', '86009387013', 'Бухгалтер', '2017-07-11'),
(3, 'Алексей', 'Волков', 'Витальевич', '1999-03-22', '86098374611', 'Проектировщик', '2023-11-01'),
(4, 'Валентин', 'Савельев', 'Генадьевич', '1995-07-11', '86009387012', 'Инженер', '2019-04-26'),
(5, 'Илья', 'Лебедев', 'Борисович', '1996-01-22', '6982951105', 'Ведущий программист', '2016-02-03');

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `staff`
--
ALTER TABLE `staff`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `SNILS` (`snils`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `staff`
--
ALTER TABLE `staff`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT COMMENT 'уникальный id в базе', AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
