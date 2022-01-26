
How to add Bootstrap, jQuery, and popper.js to Laravel 8 project using laravel-mix?
https://laravelshowcase.com/question/how-to-add-bootstrap-jquery-and-popper-js-to-laravel-8-project-using-laravel-mix

/**
	How to Install Different PHP (5.6, 7.x and 8.0) Versions in Ubuntu | https://www.tecmint.com/install-different-php-versions-in-ubuntu/
*/

# Docker

|Images - gotovie reshenia, cto soderzit funkcional, ego nelza vidoizmeniat, ego mozno skacat i na ego osnove sozdat svoej projekt.
|Container - sostoit iz obrazov?
 
$ docker run -d -p 1337:80 docker/getting-started

// run  | zapustit nekij container
// pull | skachatj nenij container
	
	// -d | detached, т.е. отсоединенный режим: мы возвращаем управление в наш терминал, а не оставляем его внутри контейнера t.e. proekt budet igratj v backgrounde.
	// -p | docker run --help | Publish a container's port(s) to the host. (soedinitj porti).
	// -D | debug, т.е. режим отладки.
		
		// 1337:80 | portPC:portVnutriDockera
	
			// docker/getting-started | nazvanie proekta
			
			
Unable to find image docker/getting-started locally // pri pervom zapuske docker ne nashel proekt (t.k. ego net), poetomu snachala on ego skachaet in zapustit.

// Dobavilos v Containers/Apps + Images

$ docker info   // polnaja infa o dockere, kakie kontaineri, kto zapuwen
$ docker images // informacija pro obrazi
$ docker ps		// pokazat spisok dostubnix containerov (container ispolzuet obraz?) + zavjazka na PORTAX!

// Proverim rabotosposobnost

http://localhost:1337

$ docker stop {ID}  // ostanovim ID -> docker ps
$ docker start {ID}
$ docker pause/unpause {ID}
$ docker kill // zestkij vixod
$ docker restart

$ docker login // docker.com

---

$ docker pull // skachatj image

dockerfile - mesto gde mozn opisatj vse podkljuchaemie obrazi.

$ docker pull openjdk
$ docker pull openjdk:latest // tozesamoe
$ docker pull openjdk:11	 // versiju

// zapuskaem obraz

$ docker run openjdk	 // sam obraz zapustit bez containere nevozmozno, poetomu, sozdatsa container ( !!! kazdij  raz vipolnjaja eto komandu budut sozdavatsa containeri)


$ docker run -it openjdk // zapustit c interaktivnom rezime ctobi s nim vzaimodejstvovatj
/**
	Флаг -i — это сокращение для --interactive. Благодаря этому флагу поток STDIN поддерживается в открытом состоянии даже если контейнер к STDIN не подключён.
	Флаг -t — это сокращение для --tty. Благодаря этому флагу выделяется псевдотерминал, который соединяет используемый терминал с потоками STDIN и STDOUT контейнера.
	Для того чтобы получить возможность взаимодействия с контейнером через терминал нужно совместно использовать флаги -i и -t.
*/

$ docker run -it --name MyCustomName openjdk

jshell> i otkroetsa java terminal
jshell> 1+6
jshell> CTRL + d (vijti)

$ docker start MyJava

MyJava
EXITED(137) // vishli s kodom oshibki

---

$ docker pull ubuntu
$ docker run -it --name MyUbuntu ubuntu // sozdaem na osnove ubuntu 
root@gfgfg: 							// popadaem v terminal

---

VS Code

Extensions
	- Docker
	- Remote Containers
	
	
New Project

# create: Dockerfile

FROM openjdk:latest 	// s kakogo obraza berem info
COPY . /java 
	// . 			kakie faili iz tekuwego projecta budem kopirovat v docker image iz projecta -> . <- tochka znachit chto iz kornia nashego projecta. a mozno COPY /app naprimer
    // /java 		v kakuju papku mi budem pomewatj
	
WORKDIR /java // rabocaja direktorija
			  // t.e. vse faili iz "." budem pomewatj v papku ".java" i WORKDIR budet sama papka "/java"

EXPOSE 1337	  // videt rezultat v brauzere

RUN	javac Main.java		 // vipolnit dejstvie pri pervonacalnom zapuske containera, - cto-to tam dlja java // odin raz pri sozdanii kontainera
CMD ["java", "Main"]		 																			   // kazdij raz pri zapuske containere

/**
CMD ["java", "Main"] - toze samoe cto i kommanda
java Main 
*/

---

file: Main.java content: hello-world

$ docker build . // vnutri projecta
$ docker images
<none>			 // blja sodali bez imeni
$ docker image rm {id}

---

$ docker run -p 1488:1337 {id}
> hello-wordl

------------------------------------------

Docker composer (mnozestvo obrazov)

// folder: php/index.php
//			   Dockerfile


FROM php:7.2-apache (php + apache podkljuchaju)
WORKDIR /var/www/html
COPY . /var/www/html
EXPOSE 80

$ cd php // ili //
$ docker build -t my-php-app ./php

$ docker images
$ docker run -p 1337:80 -d my-php-app

// Dockerfile 		opisivaju tolko odin obraza
// Dockercompose	opisivaju neskolko

------------------------------------------

docker-compose.yml

// phpmyadmin - delaem poisk ego v dockerhube i kopiruem nastrojku dlja docker-compose