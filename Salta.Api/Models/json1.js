[
    {
        "Nombre": "Alva",
        "Apellido": "Pagano",
        "Dni": "34803204",
        "NumeroHistClincia": "321",
        "Edad": 23,
        "Sexo": 2,
        "ObraSocial" : 0,
        "FactorSanguineo": 0,
        "GrupoSanguineo": 0
    },

    {
        "Nombre": "Lucho",
        "Apellido": "Pagano",
        "Dni": "34803204",
        "NumeroHistClincia": "123",
        "Edad": 29,
        "Sexo": 1,
        "ObraSocial": 1,
        "FactorSanguineo": 1,
        "GrupoSanguineo": 1

    },

    {
        "Nombre": "Falo",
        "Apellido": "Man",
        "Dni": "34803204",
        "NumeroHistClincia": "123456",
        "Edad": 16,
        "Sexo": 2,
        "ObraSocial": 1,
        "FactorSanguineo": 2,
        "GrupoSanguineo": 2   
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