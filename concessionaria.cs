using System.Collections.Generic;
using System;

public class Concessionaria {

string localizacao;
string gerente_pri;
int ano_fund;
protected List<Veiculos> listaCarros = new List<Veiculos>(); //carros disponíveis

public void adicionarCarro(Veiculos x){
  listaCarros = x;
}

public void calcularPortfolio(){
  foreach (double i in listaCarros.getValor)
    {
    double total += i;
    }
  }

  
}