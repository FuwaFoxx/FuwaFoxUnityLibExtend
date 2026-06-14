using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FuwaFox.Extensions
{
    public static class FuwaFoxExtensions
    {
        public static void ResetTransform(this Transform transform)
        {
            transform.localPosition = Vector3.zero;
            transform.localRotation = Quaternion.identity;
            transform.localScale = Vector3.one;
        }

        public static void SetParentAsOrigin(this Transform transform, Transform parent)
        {
            transform.parent = parent;
            transform.localPosition = Vector3.zero;
            transform.localRotation = Quaternion.identity;
            transform.localScale = Vector3.one;
        }

        public static void RotateAroundAxis(this Transform transform, Vector3 axis, float angle)
        {
            transform.rotation = Quaternion.AngleAxis(angle, axis) * transform.rotation;
        }

        public static void DestroyChildren(this Transform t)
        {
            foreach (Transform child in t)
            {
                Object.Destroy(child.gameObject);
            }
        }

        public static Vector3 SetX(this Vector3 vector, float val)
        {
            return new Vector3(val, vector.y, vector.z);
        }

        public static Vector3 SetY(this Vector3 vector, float val)
        {
            return new Vector3(vector.x, val, vector.z);
        }

        public static Vector3 SetZ(this Vector3 vector, float val)
        {
            return new Vector3(vector.x, vector.y, val);
        }

        public static Vector2 ToV2(this Vector3 input) => new Vector2(input.x, input.y);
        public static Vector3 Flat(this Vector3 input) => new Vector3(input.x, 0, input.z);
        public static Vector3Int ToVector3Int(this Vector3 vec3) => new Vector3Int((int)vec3.x, (int)vec3.y, (int)vec3.z);

        /// <summary>
        /// This function implemented logics to get or add the desired component.
        /// The component will be added if it is not exist.
        /// </summary>
        /// <typeparam name="T">Component</typeparam>
        /// <param name="obj">Extended class</param>
        /// <returns>get or added component</returns>
        public static T GetOrAddComponent<T>(this GameObject obj) where T : Component
        {
            T comp = obj.GetComponent<T>();

            if (comp == null)
            {
                comp = obj.AddComponent<T>();
            }

            return comp;
        }

        public static void SetLayerRecursively(this GameObject gameObject, int layer)
        {
            gameObject.layer = layer;

            foreach (Transform child in gameObject.transform)
            {
                child.gameObject.SetLayerRecursively(layer);
            }
        }

        public static T GetRandomItem<T>(this IList<T> list)
        {
            return list[Random.Range(0, list.Count)];
        }

        public static void Fade(this SpriteRenderer renderer, float alpha)
        {
            var color = renderer.color;
            color.a = alpha;
            renderer.color = color;
        }

        public static string SplitString(this string input)
        {
            return string.Join(" ", input.ToCharArray());
        }
    }
}

