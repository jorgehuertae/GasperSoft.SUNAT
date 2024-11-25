﻿// Licencia MIT 
// Copyright (C) 2023 GasperSoft.
// Contacto: it@gaspersoft.com

using GasperSoft.SUNAT.DTO.Resumen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    internal class ComunicacionBaja1
    {
        public static ComunicacionBajaType GetDocumento()
        {
            var _baja = new ComunicacionBajaType()
            {
                fechaBaja = DateTime.Now,
                fechaGeneracion = DateTime.Now,
                detalles = new List<ItemComunicacionBajaType>()
                {
                    new ItemComunicacionBajaType()
                    {
                        tipoDocumento = "01",
                        serie = "F001",
                        numero = 1,
                        motivo = "ERROR DE DATOS" //Una breve descripcion del motivo de anulacion
                    },
                    new ItemComunicacionBajaType()
                    {
                        tipoDocumento = "01",
                        serie = "F001",
                        numero = 2,
                        motivo = "ERROR DE DATOS" //Una breve descripcion del motivo de anulacion
                    }
                }
            };

            //Cada baja puede contener 500 detalles por cada bloque del dia
            //se va asignado un correlativo 1,2,3.....etc
            int _correlativo = 1;

            _baja.id = $"RA-{_baja.fechaGeneracion:yyyyMMdd}-{_correlativo}";

            return _baja;
        }
    }
}