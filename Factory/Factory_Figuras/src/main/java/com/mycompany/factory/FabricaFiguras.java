/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.factory;

/**
 *
 * @author radaz
 */
public class FabricaFiguras {

    public static Figura dibujarFigura(String tipoFigura) {

        if (tipoFigura == null) {
            return null;
        }
        
        if (tipoFigura.equalsIgnoreCase("CIRCULO")) {
            return new Circulo();
        } else if (tipoFigura.equalsIgnoreCase("RECTANGULO")) {
            return new Rectangulo();
        } else if (tipoFigura.equalsIgnoreCase("CUADRADO")) {
            return new Cuadrado();
        } else {
            throw new IllegalStateException("Unexpected value: " + tipoFigura);
        }

    }
}
