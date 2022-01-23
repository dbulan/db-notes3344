/**
	How to Install Different PHP (5.6, 7.x and 8.0) Versions in Ubuntu | https://www.tecmint.com/install-different-php-versions-in-ubuntu/
*/

# Docker
 
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
$ docker restart

$ docker login // docker.com