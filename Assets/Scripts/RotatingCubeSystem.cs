using Unity.Entities;
using Unity.Transforms;

public partial struct RotatingCubeSystem : ISystem
{
    public void OnUpdate(ref SystemState state)
    {
        foreach(var (localTransfom, rotateSpeed) in SystemAPI.Query<RefRW<LocalTransform>, RefRO<RotateSpeed>>())
        {
            localTransfom.ValueRW = localTransfom.ValueRO.RotateY(rotateSpeed.ValueRO.value * SystemAPI.Time.DeltaTime);
        }
    }
}
