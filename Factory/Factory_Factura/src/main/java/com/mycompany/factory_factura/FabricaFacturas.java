/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.factory_factura;

/**
 *
 * @author radaz
 */
public class FabricaFacturas {

    public static Factura getFactura(String tipo) {

        if (tipo.equals("iva")) {
            return new FacturaIva();
        } else {
            return new FacturaIvaReducido();
        }
    }
}
