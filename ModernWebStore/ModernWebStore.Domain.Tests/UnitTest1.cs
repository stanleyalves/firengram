﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModernWebStore.Domain.Entities;

namespace ModernWebStore.Domain.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var category = new Category("Placa Mãe");
            var product = new Product();

            category.Title = "";


            // Salvar Categoria
        }
    }
}
