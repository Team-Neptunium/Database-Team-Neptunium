﻿namespace BoardgameSimulator.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Collections.Generic;

    public class Hero
    {
        private ICollection<Item> items;

        public Hero()
        {
            this.Id = Guid.NewGuid();
            this.items = new HashSet<Item>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int? UnitId { get; set; }

        [ForeignKey("UnitId")]
        public virtual Unit Unit { get; set; }

        public int? SkillId { get; set; }

        [ForeignKey("SkillId")]
        public virtual Skill Skill { get; set; }

        public virtual ICollection<Item> Items
        {
            get { return this.items; }
            set { this.items = value; }
        }
    }
}
