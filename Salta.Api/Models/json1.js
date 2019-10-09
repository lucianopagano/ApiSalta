[

    {
        "Nombre": "German",
        "Apellido": "Ruiz",
        "DocumentoDeIdentidad": "34803204",
        "NumeroOrden": "321",
        "Edad": 23,
        "Genero": 2,
        "ObraSocial" : 0,
        "FactorSanguineo" : 0,
        "GrupoSanguineo" : 0
    }

    {
        "Nombre": "Lucho",
        "Apellido": "Ruiz",
        "DocumentoDeIdentidad": "34803204",
        "NumeroOrden": "321",
        "Edad": 18,
        "Genero": 1,
        "ObraSocial": 2,
        "FactorSanguineo": 0,
        "GrupoSanguineo": 1
    }
]

db.Sexo.insert( { "Codigo": 2, "Descripcion": "Masculino" });
db.Sexo.insert({ "Codigo": 1, "Descripcion": "Femenino" });
db.ObraSocial.insert({ "Codigo": 0,"Descripcion": "Swiss Medical"});
db.ObraSocial.insert({ "Codigo": 1,"Descripcion": "Pami"});
db.ObraSocial.insert({ "Codigo": 2,"Descripcion": "IOMA"});

db.Factor.insert({ "Codigo": 0, "Descripcion": "R+" });
db.Factor.insert({ "Codigo": 1, "Descripcion": "R-" });

db.GrupoSanguineo.insert({ "Codigo": 0, "Descripcion": "A" });
db.GrupoSanguineo.insert({ "Codigo": 1, "Descripcion": "AB" });
db.GrupoSanguineo.insert({ "Codigo": 2, "Descripcion": "B" });
db.GrupoSanguineo.insert({ "Codigo": 3, "Descripcion": "0" });



//db.FactorSanguineo.insert({ "Codigo": 0, "Descripcion": "A+" });
//db.FactorSanguineo.insert({ "Codigo": 1, "Descripcion": "0+" });
//db.FactorSanguineo.insert({ "Codigo": 2, "Descripcion": "A-" });