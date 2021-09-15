using System.Collections.Generic;
using System;

public class Importados : Veiculos {

  protected override void definirValorVeiculo(double custoFixo){

    valor = custoFixo*3.0+0.6*custoFixo+custoFixo;
  }



}