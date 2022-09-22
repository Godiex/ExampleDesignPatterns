/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.factory_factura;

/**
 *
 * @author radaz
 */
public class FacturaIvaReducido extends Factura {

    @Override
    public double getImporteIva() {
        // TODO Auto-generated method stub
        System.out.println("Factura IVA reducido");
        return getImporte() * 1.07;
    }
}
