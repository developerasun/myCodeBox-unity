using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// class B inherits from class A ===> one class cannot inherit multiple classes
// class B implements interface A ===> one class can implement multiple interfaces
// interface : 1) provides a wide range of funcitonality 2) provides a shared functionality 
// to quite different classes( e.g laptop, chair => IBreakable )
public interface IKillable
{
    void kill();
}

public interface IDemagable<T> 
{
    void Damage(T damageTaken);
}