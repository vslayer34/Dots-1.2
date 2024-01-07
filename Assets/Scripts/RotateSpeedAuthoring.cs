using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;

public class RotateSpeedAuthoring : MonoBehaviour
{
    public float value;

    private class Baker : Baker<RotateSpeedAuthoring>
    {
        public override void Bake(RotateSpeedAuthoring authoring)
        {
            var entity = GetEntity(TransformUsageFlags.Dynamic);
            AddComponentObject(entity, new RotateSpeed
            {
                value = authoring.value
            });
        }
    }
}


public class RotateSpeed : IComponentData
{
    public float value;
}