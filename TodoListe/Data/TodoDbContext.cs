﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using TodoListe.Models;

namespace TodoListe.Data
{
    public class TodoDbContext:DbContext
    {
      public TodoDbContext(): base("TodoListConnectionString")
        {
        }

        /* Une classe gen ne sait pas q'l type q'l va manip, mais une fois en memo on va lui fournir le type a manip puis elle va s'adaptater au type */
        // "DbSet<T>" Une classe generique car elle aplique la generissité
        public DbSet<Categorie> Categories { get; set; } // pluriel dans les DbContext
        public DbSet<Tache> Taches { get; set; } // on integre le model de la table Taches, une fois ecrit on fait l'integration de cette table "add-migration Init"
    }
}

/* Ne jamais suprimer un fichier de migration de base de donnee.
 Systeme de migr permet le transfert de la structure de la BD
 Ligne de creation dans la console :
 PM> add-migration Init
 */
