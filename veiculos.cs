using System.Collections.Generic;
using System;

public abstract class Veiculos {

  private string cor;
  private string marca;
  protected string modelo;
  protected double valor;
  private int ano;


  //SET
  public void setCor(string c){
    cor = c;
  }
  public void setMarca(string m){
    marca = m;
  }
  public void setAno(int a){
   ano = a;
  }


  //GET
  public string getCor(){
   return cor;
  }
  public string getMarca(){
    return marca;
  }
  public double getAno(){
    return ano;
  }

  protected virtual void definirValorVeiculo(double CustoFixo){
    //valor = CustoFixo;
  }


}