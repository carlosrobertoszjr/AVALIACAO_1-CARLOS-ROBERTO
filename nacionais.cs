using System.Collections.Generic;
using System;

public class Nacionais : Veiculos {
  protected override void definirValorVeiculo(double custoFixo){
    valor = custoFixo*1.5+0.2*custoFixo;
  }

}