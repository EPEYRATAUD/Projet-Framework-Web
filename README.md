# Epic Race Events - Projet Fil Rouge FrameworkWeb

MVP (Minimum Viable Product) voie le jour d’ici le 8 Avril 2022.

Contraintes techniques :
Framework : ASP.NET MVC
Site web dynamique : pas de SPA pour l’instant. Cependant je veux pouvoir réutiliser un maximum le système que vous allez créer si la décision est prise de rajouter des fronts ((SPA React.js / App Mobile) + API par ex).
Base de données : MySQL, mais je veux pouvoir basculer facilement si on voit que c’est pas adapté.

Interface graphique :
HTML / CSS / JS
Champ libre (utilisation de bootstrap / tailwind ou autre framework CSS OK,  scripts JS / JQuery OK…).
Soyez créatifs, mais ne perdez pas de vue que je souhaite qu’on se concentre sur la robustesse et l’évolutivité du back end !
N’hésitez pas à vous répartir les tâches en fonction de vos compétences / appétences.

Le projet doit être runnable avec le SDK net 6 installé -  après un git clone + dotnet runs
Présentation (support slides) / Démo 10-15mn + 5mn questions.

## Routes

### **page d’accueil du site  “/” :**

Un compteur qui affiche les jours, heures minutes et sec restantes avant la prochaine course
Les 3 prochaines courses à venir, sous la forme d’un carrousel
Les résultats de la dernière course, sous forme d’un tableau

### **“/Races”, accessible via la page d’accueil**

Toutes les courses, triées par date croissante.
Afficher à minima :
le nom
la date de l’évènement
l’heure de départ
le nombre de places restantes

### **“Races/{id de la course} accessible via le carousel de la page d’accueil ET les lignes de tableau de la page “Races”**

Les détails d’une course passée ou à venir (afficher toutes les infos à disposition)
Afficher une carte indiquant l’endroit ou la course a lieu - latitude / longitude => maps

### "/createAccount"

Accessible via le menu du site.
Le formulaire du profil de pilote :
email : email
mdp : min 8 max 15 : 1 majuscule min, 1 chiffre min
prénom min: 2 max: 30 - alpha
nom  min 2 max 30 - alpha
date de naissance (jour mois année) > 16 ans

A l’inscription, le pilote obtient un véhicule au hasard (imaginer comment lui informer qu’il a reçu tel véhicule)
Un mail de confirmation est envoyé, Contenu du mail : “Salut <fullname>, ton l’inscription à <nom de la course>, ayant le lieu le <date> à <heure> est confirmée ! Lorem ipsum …” + Logo de l’app

### **/login**

Accessible via menu du site, ou si l’utilisateur tente de rejoindre une course / consulter son profil sans être authentifié.
Login via email et mdp.
Si le login est réussi, l’utilisateur est redirigé sur la page d’accueil.

### **/Profile (ou autre label), accessible via le menu principal**

Contient
toutes les infos du profil
la liste des véhicules possédés par le pilote.
les inscriptions passées et futures

### **/Profile/Edit (ou autre label), accessible via la page profil**

Permet de modifier uniquement le prénom et le nom du pilote.

Dans ce MVP, un pilote ne peut pas supprimer son compte ! (ouai, c’est pas très RGPD #jesuisfacebook)

### **/raceInscription**

Accessible uniquement par les pilotes authentifiés sur le site.
 via :
Le carrousel “3 prochaines courses” (page d’accueil “/”) : un bouton sur chacun des items doit être dispo pour s’inscrire
Liste des courses “Races” (bouton dispo sur chaque ligne, uniquement sur les courses à venir)

Déroulement d’une l’inscription :
Le pilote appuie sur le bouton pour s’inscrire à la course
On vérifie que le pilote est bien autorisé à la rejoindre (âge, places restantes) - affiche un message avec raison si refusé.
Si ok, l’utilisateur est redirigé vers une page d’inscription à la course.
La page affiche les catégories de véhicules autorisés
Choix d’un véhicule parmi les véhicules du pilote : la liste doit proposer tous les véhicules du pilote, mais ne permet de sélectionner qu’un véhicule autorisé.
Confirmation d’inscription
Envoi d’un mail de confirmation d’inscription

Une inscription c’est donc en substance un lien entre :
une course
un pilote
un véhicule

Dans ce MVP, on ne peut pas se désinscrire d’une course.

### (/Race/{Id}), dispo pour les admins uniquement

Simuler une course :
Générer des résultats pour une course donnée.
Dans ce MVP, un admin peut simuler plusieurs fois une course
On ne peut pas simuler une courses avec moins de 2 pilotes inscrits
Aucune restriction sur les dates pour cette v1
Une fois la course simulée, la page de détail est rafraîchie et contient désormais les résultats générés !

Un résultat, c’est en ensemble de lignes de résultats, à vous de modéliser ça comme il faut :)

### /manageRaces

Ce module est accessible via le menu du site uniquement accessible par un utilisateur authentifié, qui a le rôle d’administrateur.

Gérer
Visualiser (mêmes droits que tous les autres utilisateurs) :
Toutes les courses, triées par date croissante
Les détails d’une course passée ou future

Créer :
Accessible uniquement par l’admin, via la page “Races” (liste de courses)
Redirige vers la page de création d’une nouvelle course “Races/Edit”

Modifier :
Accessible uniquement par l’admin, via la page “Races” (liste de courses)
Redirige vers la page d’édition d’une course “Races/Edit”

Cette page est un formulaire “basique” (v. modèle de donnée -> course)

Un admin NE PEUT PAS S’INSCRIRE À UNE COURSE et ne possède pas non plus de véhicules !

### “/Drivers”

accessible via le menu du site, disponible uniquement pour les administrateurs.

Gérer :
Visualiser les pilotes
Chercher un pilote par son prénom, nom ou email (au sein d’un même champ de recherche idéalement)
Donner un véhicule à un pilote
Enlever un véhicule à un pilote

On ne peut pas enlever tous les véhicules d’un pilote !
On ne peut pas donner 2 fois le même véhicule à un pilote !

## Modèle de données

 **Une course :**

- Un identifiant
- Un nom (length: min 2, max 50 (requis)
- Une date d'événement (requis)
- Une heure de départ de course (requis)
- Une latitude (lieu de rassemblement) (requis)
- Une longitude (lieu de rassemblement) (requis)
- Un nombre max de participants (15 par défaut)
- Une image (url vers une image de course)
- Des pilotes qui participent à la course (vide par défaut)
- Une restriction d’âge (+21 ans par défaut)
- Un résultat (si la course a eu lieu)
- Des catégories de véhicules autorisés (requis) - ne doit pas être vide !

**Un pilote :**

- Un identifiant
- Un prénom (length: min 2 max: 30, requis)
- Un nom (length: min 2 max: 30, requis)
- Une date de naissance (requis, type date only)
- Un email (requis, unique, type mail)
- Un mot de passe (requis)
- Des véhicules possédés
- Des courses auxquelles il a / va participer (vide par défaut)

**Un véhicule :**

- Un identifiant
- Des catégories (Super Car, Hyper Car, Japan Race Car, German Classics…) (requis)
- Une année de construction
- Une marque (requis)
- Un modèle (requis)
- Un niveau de puissance (requis) de 1 à 10.
- Des pilotes possédant ce véhicule (many to many)
- Une image (url vers l’image du véhicule)

    **Une catégorie de véhicule**
- Un identifiant
- Un nom
- Une description
- Une image (url)
- Une couleur (code hexadécimal)
