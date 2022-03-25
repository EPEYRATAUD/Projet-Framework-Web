///en cours

create table course (
    Id
    Name (length: min 2, max 50 (requis),
    EventDate (requis),
    StartHour (requis),
    Latitude (lieu de rassemblement) (requis),
    Longitude (lieu de rassemblement) (requis),
    ParticipantsMaxAmount (15 par défaut),
    image (url vers une image de course),
    Pilotes [] qui participent à la course (vIde par défaut),
    minAge (+21 ans par défaut),
    result (si la course a eu lieu),
    catégories [] de véhicules autorisés (requis) - ne doit pas être vIde !,
)

create table pilote (
    Id
    firstName (length: min 2 max: 30, requis)
    lastName (length: min 2 max: 30, requis)
    birthdate (requis, type date only)
    email (requis, unique, type mail)
    password (requis)
    ownedVehicules
    races courses auxquelles il a / va participer (vIde par défaut)
)

create table car (
    Id
    categories (Super Car, Hyper Car, Japan Race Car, German Classics…) (requis)
    constructionYear
    brand (requis)
    model (requis)
    powerLevel (requis) de 1 à 10.
    owners possédant ce véhicule (many to many)
    image (url vers l’image du véhicule)

)

create table vehiculeCategory (
    Id
    nom
    description
    image (url)
    couleur (code hexadécimal)
)
