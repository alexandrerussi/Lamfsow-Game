using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbita : MonoBehaviour
{
    /// <ClassName>
    ///     Orbita
    /// </ClassName>
    /// 
    /// <Autor>
    ///     @DanielMoraes
    /// </Autor>
    /// 
    /// <Date>
    ///     05/07/2019
    /// </Date>
    /// 
    /// <summary>
    ///     Código para simular uma órbita, tirando um cálculo x para iniciar a lógica
    /// </summary>
    /// 

    public float xSpread;//O quão longe nos moveremos. Algo como o raio da órbita.
    public float zSpread;
    public float yOffset;//Vai ser estático mas importante para a câmera
    public Transform centerPoint;

    public float rotSpeed;//Velocidade de rotação
    public bool rotateClockwise;//Muda a direção em que orbitamos

    float timer = 0;

    // Update is called once per frame
    void Update(){
        timer += Time.deltaTime * rotSpeed;//Incrementar primeiro
        Rotate();
        transform.LookAt(centerPoint);//Transformar o ângulo de câmera, só serve pra esse tipo de objeto

    }

    void Rotate()
    {
        if (rotateClockwise)//Orbitando em sentido horário
        {
            float x = -Mathf.Cos(timer) * xSpread;
            float z = Mathf.Sin(timer) * zSpread;
            Vector3 pos = new Vector3(x, yOffset, z);//Instanciando Vector3, um vetor tridimensional
            transform.position = pos + centerPoint.position;
            print("Orbitando em sentido horário");
        }
        else
        {
            float x = Mathf.Cos(timer) * xSpread;
            float z = Mathf.Sin(timer) * zSpread;
            Vector3 pos = new Vector3(x, yOffset, z);//Instanciando Vector3, um vetor tridimensional
            transform.position = pos + centerPoint.position;
            print("Orbitando em sentido anti-horário");
        }
    }
}
