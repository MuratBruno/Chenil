#!/bin/sh
docker-compose build
docker-compose up
read -p "Installation terminée consulter le site sur http://localhost:4202"