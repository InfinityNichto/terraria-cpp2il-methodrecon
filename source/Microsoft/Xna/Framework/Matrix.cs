using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework
{
	// Token: 0x0200032A RID: 810
	[Serializable]
	public struct Matrix : IEquatable<Matrix>
	{
		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x060012A9 RID: 4777 RVA: 0x0005A288 File Offset: 0x00058488
		public static Matrix Identity
		{
			get
			{
				if (!true)
				{
				}
				return 1;
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x060012AA RID: 4778 RVA: 0x0005A29C File Offset: 0x0005849C
		// (set) Token: 0x060012AB RID: 4779 RVA: 0x0005A2C0 File Offset: 0x000584C0
		public Vector3 Backward
		{
			get
			{
				float m = this.M31;
				float m2 = this.M32;
				float m3 = this.M33;
				Vector3 vector;
				return vector;
			}
			set
			{
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x060012AC RID: 4780 RVA: 0x0005A2D0 File Offset: 0x000584D0
		// (set) Token: 0x060012AD RID: 4781 RVA: 0x0005A2F4 File Offset: 0x000584F4
		public Vector3 Down
		{
			get
			{
				float m = this.M21;
				float m2 = this.M22;
				float m3 = this.M23;
				Vector3 vector;
				return vector;
			}
			set
			{
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x060012AE RID: 4782 RVA: 0x0005A304 File Offset: 0x00058504
		// (set) Token: 0x060012AF RID: 4783 RVA: 0x0005A328 File Offset: 0x00058528
		public Vector3 Forward
		{
			get
			{
				float m = this.M31;
				float m2 = this.M32;
				float m3 = this.M33;
				Vector3 vector;
				return vector;
			}
			set
			{
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x060012B0 RID: 4784 RVA: 0x0005A338 File Offset: 0x00058538
		// (set) Token: 0x060012B1 RID: 4785 RVA: 0x0005A35C File Offset: 0x0005855C
		public Vector3 Left
		{
			get
			{
				float m = this.M11;
				float m2 = this.M12;
				float m3 = this.M13;
				Vector3 vector;
				return vector;
			}
			set
			{
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x060012B2 RID: 4786 RVA: 0x0005A36C File Offset: 0x0005856C
		// (set) Token: 0x060012B3 RID: 4787 RVA: 0x0005A390 File Offset: 0x00058590
		public Vector3 Right
		{
			get
			{
				float m = this.M11;
				float m2 = this.M12;
				float m3 = this.M13;
				Vector3 vector;
				return vector;
			}
			set
			{
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x060012B4 RID: 4788 RVA: 0x0005A3A0 File Offset: 0x000585A0
		// (set) Token: 0x060012B5 RID: 4789 RVA: 0x0005A3C4 File Offset: 0x000585C4
		public Vector3 Translation
		{
			get
			{
				float m = this.M41;
				float m2 = this.M42;
				float m3 = this.M43;
				Vector3 vector;
				return vector;
			}
			set
			{
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x060012B6 RID: 4790 RVA: 0x0005A3D4 File Offset: 0x000585D4
		// (set) Token: 0x060012B7 RID: 4791 RVA: 0x0005A3F8 File Offset: 0x000585F8
		public Vector3 Up
		{
			get
			{
				float m = this.M21;
				float m2 = this.M22;
				float m3 = this.M23;
				Vector3 vector;
				return vector;
			}
			set
			{
			}
		}

		// Token: 0x060012B8 RID: 4792 RVA: 0x0005A408 File Offset: 0x00058608
		public Matrix(float m11, float m12, float m13, float m14, float m21, float m22, float m23, float m24, float m31, float m32, float m33, float m34, float m41, float m42, float m43, float m44)
		{
		}

		// Token: 0x060012B9 RID: 4793 RVA: 0x0005A418 File Offset: 0x00058618
		public static Matrix CreateWorld(Vector3 position, Vector3 forward, Vector3 up)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x060012BA RID: 4794 RVA: 0x0005A42C File Offset: 0x0005862C
		public static void CreateWorld(Vector3 position, Vector3 forward, Vector3 up, [Out] Matrix result)
		{
			if (!true)
			{
			}
			Vector3.Normalize(forward, forward);
			forward.Normalize();
			forward.Normalize();
			result.M11 = (float)1;
			result.M21 = (float)1;
			float z = position.Z;
			result.M43 = z;
		}

		// Token: 0x060012BB RID: 4795 RVA: 0x0005A46C File Offset: 0x0005866C
		public static Matrix CreateShadow(Vector3 lightDirection, Plane plane)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x060012BC RID: 4796 RVA: 0x0005A480 File Offset: 0x00058680
		public static void CreateShadow(Vector3 lightDirection, Plane plane, [Out] Matrix result)
		{
			float d = plane.D;
			float x = plane.Normal.X;
			float y = plane.Normal.Y;
			float z = plane.Normal.Z;
			float x2 = lightDirection.X;
			float y2 = lightDirection.Y;
			float z2 = lightDirection.Z;
			if (!true)
			{
			}
			float y3 = lightDirection.Y;
			float z3 = lightDirection.Z;
			result.M42 = y3;
			result.M23 = y;
			result.M43 = y3;
			result.M44 = d;
		}

		// Token: 0x060012BD RID: 4797 RVA: 0x0005A508 File Offset: 0x00058708
		public static void CreateReflection(Plane value, [Out] Matrix result)
		{
			float d = value.D;
			float x = value.Normal.X;
			float y = value.Normal.Y;
			float z = value.Normal.Z;
			result.M41 = x;
			result.M42 = y;
			result.M43 = d;
			result.M33 = z;
			result.M44 = (float)16256;
		}

		// Token: 0x060012BE RID: 4798 RVA: 0x0005A56C File Offset: 0x0005876C
		public static Matrix CreateReflection(Plane value)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x060012BF RID: 4799 RVA: 0x0005A580 File Offset: 0x00058780
		public static Matrix CreateFromYawPitchRoll(float yaw, float pitch, float roll)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			Matrix matrix;
			matrix.M31 = pitch;
			matrix.M32 = yaw;
			matrix.M12 = roll;
			return 1;
		}

		// Token: 0x060012C0 RID: 4800 RVA: 0x0005A5AC File Offset: 0x000587AC
		public static void CreateFromYawPitchRoll(float yaw, float pitch, float roll, [Out] Matrix result)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x060012C1 RID: 4801 RVA: 0x0005A5C0 File Offset: 0x000587C0
		public static void Transform(Matrix value, Quaternion rotation, [Out] Matrix result)
		{
			float x = rotation.X;
			float y = rotation.Y;
			float z = rotation.Z;
			float w = rotation.W;
			if (!true)
			{
			}
		}

		// Token: 0x060012C2 RID: 4802 RVA: 0x0005A5EC File Offset: 0x000587EC
		public static Matrix Transform(Matrix value, Quaternion rotation)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x060012C3 RID: 4803 RVA: 0x0005A600 File Offset: 0x00058800
		public bool Decompose([Out] Vector3 scale, [Out] Quaternion rotation, [Out] Vector3 translation)
		{
			float m = this.M41;
			translation.X = m;
			float m2 = this.M43;
			translation.Z = m2;
			float m3 = this.M11;
			float m4 = this.M12;
			float m5 = this.M13;
			float m6 = this.M14;
			if (m2 == null)
			{
			}
			float m7 = this.M21;
			float m8 = this.M22;
			float m9 = this.M23;
			float m10 = this.M24;
			int num;
			if (num == 0)
			{
			}
			float m11 = this.M31;
			float m12 = this.M32;
			float m13 = this.M33;
			float m14 = this.M34;
			float m15 = this.M11;
			float m16 = this.M12;
			float m17 = this.M13;
			float m18 = this.M21;
			float m19 = this.M22;
			float m20 = this.M23;
			float m21 = this.M31;
			float m22 = this.M32;
			float m23 = this.M33;
			float m24 = this.M13;
			rotation.Y = m20;
			rotation.Z = m19;
			rotation.W = m18;
			if (!true)
			{
			}
			if (!true)
			{
				return;
			}
		}

		// Token: 0x060012C4 RID: 4804 RVA: 0x0005A708 File Offset: 0x00058908
		public static Matrix Add(Matrix matrix1, Matrix matrix2)
		{
			float m = matrix1.M11;
			float m2 = matrix1.M12;
			float m3 = matrix2.M12;
			matrix1.M12 = m3;
			float m4 = matrix2.M13;
			float m5 = matrix1.M13;
			float m6 = matrix1.M14;
			matrix1.M13 = m4;
			float m7 = matrix2.M14;
			matrix1.M14 = m7;
			float m8 = matrix2.M21;
			float m9 = matrix1.M21;
			float m10 = matrix1.M22;
			matrix1.M21 = m8;
			float m11 = matrix2.M22;
			matrix1.M22 = m11;
			float m12 = matrix2.M23;
			float m13 = matrix1.M23;
			float m14 = matrix1.M24;
			matrix1.M23 = m12;
			float m15 = matrix2.M24;
			matrix1.M24 = m15;
			float m16 = matrix2.M31;
			float m17 = matrix1.M31;
			float m18 = matrix1.M32;
			matrix1.M31 = m16;
			float m19 = matrix2.M32;
			matrix1.M32 = m19;
			float m20 = matrix2.M33;
			float m21 = matrix1.M33;
			float m22 = matrix1.M34;
			matrix1.M33 = m20;
			float m23 = matrix2.M34;
			matrix1.M34 = m23;
			float m24 = matrix2.M41;
			float m25 = matrix1.M41;
			float m26 = matrix1.M42;
			matrix1.M41 = m24;
			float m27 = matrix2.M42;
			matrix1.M42 = m27;
			float m28 = matrix2.M43;
			float m29 = matrix1.M43;
			float m30 = matrix1.M44;
			matrix1.M43 = m28;
			float m31 = matrix2.M44;
			matrix1.M44 = m31;
			float m32 = matrix1.M31;
			float m33 = matrix1.M32;
			float m34 = matrix1.M11;
			float m35 = matrix1.M12;
			Matrix matrix3;
			matrix3.M31 = m32;
			matrix3.M32 = m33;
			matrix3.M11 = m34;
			matrix3.M12 = m35;
			return matrix3;
		}

		// Token: 0x060012C5 RID: 4805 RVA: 0x0005A8C4 File Offset: 0x00058AC4
		public static void Add(Matrix matrix1, Matrix matrix2, [Out] Matrix result)
		{
			float m = matrix1.M21;
			float m2 = matrix2.M21;
			result.M21 = m;
			float m3 = matrix1.M31;
			float m4 = matrix2.M31;
			result.M31 = m3;
			float m5 = matrix1.M41;
			float m6 = matrix2.M41;
			result.M41 = m5;
		}

		// Token: 0x060012C6 RID: 4806 RVA: 0x0005A914 File Offset: 0x00058B14
		public static Matrix CreateBillboard(Vector3 objectPosition, Vector3 cameraPosition, Vector3 cameraUpVector, Vector3? cameraForwardVector)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x060012C7 RID: 4807 RVA: 0x0005A928 File Offset: 0x00058B28
		public static void CreateBillboard(Vector3 objectPosition, Vector3 cameraPosition, Vector3 cameraUpVector, Vector3? cameraForwardVector, [Out] Matrix result)
		{
			float x = cameraPosition.X;
			float y = cameraPosition.Y;
			float z = cameraPosition.Z;
			float x2 = objectPosition.X;
			float y2 = objectPosition.Y;
			float z2 = objectPosition.Z;
			if (!true)
			{
			}
			Vector3 vector;
			Vector3.Normalize(vector, cameraPosition);
			Vector3.Normalize(cameraUpVector, cameraPosition);
			if (!true)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x060012C8 RID: 4808 RVA: 0x000021DB File Offset: 0x000003DB
		public static Matrix CreateConstrainedBillboard(Vector3 objectPosition, Vector3 cameraPosition, Vector3 rotateAxis, Vector3? cameraForwardVector, Vector3? objectForwardVector)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060012C9 RID: 4809 RVA: 0x000021DB File Offset: 0x000003DB
		public static void CreateConstrainedBillboard(Vector3 objectPosition, Vector3 cameraPosition, Vector3 rotateAxis, Vector3? cameraForwardVector, Vector3? objectForwardVector, [Out] Matrix result)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060012CA RID: 4810 RVA: 0x000021DB File Offset: 0x000003DB
		public static Matrix CreateFromAxisAngle(Vector3 axis, float angle)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060012CB RID: 4811 RVA: 0x000021DB File Offset: 0x000003DB
		public static void CreateFromAxisAngle(Vector3 axis, float angle, [Out] Matrix result)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060012CC RID: 4812 RVA: 0x0005A97C File Offset: 0x00058B7C
		public static Matrix CreateFromQuaternion(Quaternion quaternion)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x060012CD RID: 4813 RVA: 0x0005A990 File Offset: 0x00058B90
		public static void CreateFromQuaternion(Quaternion quaternion, [Out] Matrix result)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			float y = quaternion.Y;
			float z = quaternion.Z;
			float w = quaternion.W;
			result.M31 = y;
			result.M32 = z;
			result.M13 = w;
			result.M33 = y;
		}

		// Token: 0x060012CE RID: 4814 RVA: 0x0005A9D4 File Offset: 0x00058BD4
		public static Matrix CreateLookAt(Vector3 cameraPosition, Vector3 cameraTarget, Vector3 cameraUpVector)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x060012CF RID: 4815 RVA: 0x0005A9E8 File Offset: 0x00058BE8
		public static void CreateLookAt(Vector3 cameraPosition, Vector3 cameraTarget, Vector3 cameraUpVector, [Out] Matrix result)
		{
			float x = cameraTarget.X;
			float y = cameraTarget.Y;
			float z = cameraTarget.Z;
			float x2 = cameraPosition.X;
			float y2 = cameraPosition.Y;
			float z2 = cameraPosition.Z;
			if (!true)
			{
			}
			float z3 = cameraUpVector.Z;
			float x3 = cameraUpVector.X;
			float y3 = cameraUpVector.Y;
			if (!true)
			{
			}
			if (!true)
			{
			}
			result.M13 = x2;
			result.M23 = y2;
			result.M12 = x;
			result.M22 = z2;
			result.M31 = z;
			result.M32 = x2;
			result.M33 = y;
			float x4 = cameraPosition.X;
			float y4 = cameraPosition.Y;
			float z4 = cameraPosition.Z;
			result.M41 = x3;
			float x5 = cameraPosition.X;
			float y5 = cameraPosition.Y;
			float z5 = cameraPosition.Z;
			result.M42 = x3;
			float x6 = cameraPosition.X;
			float y6 = cameraPosition.Y;
			float z6 = cameraPosition.Z;
			result.M43 = x3;
		}

		// Token: 0x060012D0 RID: 4816 RVA: 0x0005AAF0 File Offset: 0x00058CF0
		public static Matrix CreateOrthographic(float width, float height, float zNearPlane, float zFarPlane)
		{
			if (!true)
			{
			}
			Matrix matrix;
			matrix.M44 = (float)16256;
			return 16256;
		}

		// Token: 0x060012D1 RID: 4817 RVA: 0x0005AB10 File Offset: 0x00058D10
		public static void CreateOrthographic(float width, float height, float zNearPlane, float zFarPlane, [Out] Matrix result)
		{
			result.M44 = (float)16256;
		}

		// Token: 0x060012D2 RID: 4818 RVA: 0x0005AB2C File Offset: 0x00058D2C
		public static Matrix CreateOrthographicOffCenter(float left, float right, float bottom, float top, float zNearPlane, float zFarPlane)
		{
			if (!true)
			{
			}
			Matrix matrix;
			matrix.M41 = zNearPlane;
			matrix.M44 = (float)16256;
			return 16256;
		}

		// Token: 0x060012D3 RID: 4819 RVA: 0x0005AB54 File Offset: 0x00058D54
		public static void CreateOrthographicOffCenter(float left, float right, float bottom, float top, float zNearPlane, float zFarPlane, [Out] Matrix result)
		{
			result.M41 = left;
			result.M44 = (float)16256;
		}

		// Token: 0x060012D4 RID: 4820 RVA: 0x000021DB File Offset: 0x000003DB
		public static Matrix CreatePerspective(float width, float height, float zNearPlane, float zFarPlane)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060012D5 RID: 4821 RVA: 0x000021DB File Offset: 0x000003DB
		public static void CreatePerspective(float width, float height, float zNearPlane, float zFarPlane, [Out] Matrix result)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060012D6 RID: 4822 RVA: 0x0005AB78 File Offset: 0x00058D78
		public static Matrix CreatePerspectiveFieldOfView(float fieldOfView, float aspectRatio, float nearPlaneDistance, float farPlaneDistance)
		{
			if (!true)
			{
			}
			Matrix matrix;
			matrix.M31 = aspectRatio;
			matrix.M32 = fieldOfView;
			matrix.M11 = farPlaneDistance;
			matrix.M12 = nearPlaneDistance;
			return 1;
		}

		// Token: 0x060012D7 RID: 4823 RVA: 0x0005ABA8 File Offset: 0x00058DA8
		public static void CreatePerspectiveFieldOfView(float fieldOfView, float aspectRatio, float nearPlaneDistance, float farPlaneDistance, [Out] Matrix result)
		{
			result.M31 = fieldOfView;
			result.M32 = fieldOfView;
			result.M11 = fieldOfView;
			result.M12 = fieldOfView;
			result.M34 = (float)49024;
		}

		// Token: 0x060012D8 RID: 4824 RVA: 0x000021DB File Offset: 0x000003DB
		public static Matrix CreatePerspectiveOffCenter(float left, float right, float bottom, float top, float zNearPlane, float zFarPlane)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060012D9 RID: 4825 RVA: 0x000021DB File Offset: 0x000003DB
		public static void CreatePerspectiveOffCenter(float left, float right, float bottom, float top, float nearPlaneDistance, float farPlaneDistance, [Out] Matrix result)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060012DA RID: 4826 RVA: 0x0005ABE4 File Offset: 0x00058DE4
		public static Matrix CreateRotationX(float radians)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			Matrix matrix;
			matrix.M21 = (float)1;
			return 1;
		}

		// Token: 0x060012DB RID: 4827 RVA: 0x0005AC04 File Offset: 0x00058E04
		public static void CreateRotationX(float radians, [Out] Matrix result)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			result.M31 = radians;
			if (!true)
			{
			}
		}

		// Token: 0x060012DC RID: 4828 RVA: 0x0005AC24 File Offset: 0x00058E24
		public static Matrix CreateRotationY(float radians)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			Matrix matrix;
			matrix.M24 = (float)1;
			return 1;
		}

		// Token: 0x060012DD RID: 4829 RVA: 0x0005AC44 File Offset: 0x00058E44
		public static void CreateRotationY(float radians, [Out] Matrix result)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			result.M31 = radians;
			if (!true)
			{
			}
		}

		// Token: 0x060012DE RID: 4830 RVA: 0x0005AC64 File Offset: 0x00058E64
		public static Matrix CreateRotationZ(float radians)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			Matrix matrix;
			matrix.M43 = (float)1;
			return 1;
		}

		// Token: 0x060012DF RID: 4831 RVA: 0x0005AC84 File Offset: 0x00058E84
		public static void CreateRotationZ(float radians, [Out] Matrix result)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			result.M31 = radians;
			if (!true)
			{
			}
		}

		// Token: 0x060012E0 RID: 4832 RVA: 0x0005ACA4 File Offset: 0x00058EA4
		public static Matrix CreateScale(float scale)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			Matrix matrix;
			matrix.M44 = (float)1;
			return 1;
		}

		// Token: 0x060012E1 RID: 4833 RVA: 0x0005ACC0 File Offset: 0x00058EC0
		public static void CreateScale(float scale, [Out] Matrix result)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			result.M11 = scale;
		}

		// Token: 0x060012E2 RID: 4834 RVA: 0x0005ACDC File Offset: 0x00058EDC
		public static Matrix CreateScale(float xScale, float yScale, float zScale)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			Matrix matrix;
			matrix.M44 = (float)1;
			return 1;
		}

		// Token: 0x060012E3 RID: 4835 RVA: 0x0005ACF8 File Offset: 0x00058EF8
		public static void CreateScale(float xScale, float yScale, float zScale, [Out] Matrix result)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			result.M11 = xScale;
			result.M12 = yScale;
			result.M31 = zScale;
		}

		// Token: 0x060012E4 RID: 4836 RVA: 0x0005AD20 File Offset: 0x00058F20
		public static Matrix CreateScale(Vector3 scales)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			Matrix matrix;
			matrix.M44 = (float)1;
			return 1;
		}

		// Token: 0x060012E5 RID: 4837 RVA: 0x0005AD3C File Offset: 0x00058F3C
		public static void CreateScale(Vector3 scales, [Out] Matrix result)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			float y = scales.Y;
			result.M22 = y;
			float z = scales.Z;
			result.M33 = z;
		}

		// Token: 0x060012E6 RID: 4838 RVA: 0x0005AD6C File Offset: 0x00058F6C
		public static Matrix CreateTranslation(float xPosition, float yPosition, float zPosition)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			Matrix matrix;
			matrix.M11 = xPosition;
			matrix.M21 = yPosition;
			matrix.M22 = zPosition;
			return 1;
		}

		// Token: 0x060012E7 RID: 4839 RVA: 0x0005AD98 File Offset: 0x00058F98
		public static void CreateTranslation(float xPosition, float yPosition, float zPosition, [Out] Matrix result)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			result.M31 = xPosition;
			result.M32 = yPosition;
			result.M11 = zPosition;
		}

		// Token: 0x060012E8 RID: 4840 RVA: 0x0005ADC0 File Offset: 0x00058FC0
		public static Matrix CreateTranslation(Vector3 position)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x060012E9 RID: 4841 RVA: 0x0005ADD4 File Offset: 0x00058FD4
		public static void CreateTranslation(Vector3 position, [Out] Matrix result)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			float z = position.Z;
			result.M43 = z;
		}

		// Token: 0x060012EA RID: 4842 RVA: 0x0005ADF8 File Offset: 0x00058FF8
		public static Matrix Divide(Matrix matrix1, Matrix matrix2)
		{
			float m = matrix2.M31;
			float m2 = matrix2.M32;
			float m3 = matrix2.M11;
			float m4 = matrix2.M12;
			if (!true)
			{
			}
			float m5 = matrix1.M13;
			float m6 = matrix1.M14;
			float m7 = matrix1.M21;
			float m8 = matrix1.M22;
			float m9 = matrix1.M23;
			float m10 = matrix1.M24;
			float m11 = matrix1.M31;
			float m12 = matrix1.M32;
			float m13 = matrix1.M33;
			float m14 = matrix1.M34;
			float m15 = matrix1.M41;
			float m16 = matrix1.M42;
			float m17 = matrix1.M43;
			float m18 = matrix1.M44;
			Matrix matrix3;
			matrix3.M11 = m2;
			matrix3.M12 = m;
			matrix3.M42 = m3;
			return matrix1;
		}

		// Token: 0x060012EB RID: 4843 RVA: 0x0005AEAC File Offset: 0x000590AC
		public static void Divide(Matrix matrix1, Matrix matrix2, [Out] Matrix result)
		{
			float m = matrix2.M31;
			float m2 = matrix2.M32;
			float m3 = matrix2.M11;
			float m4 = matrix2.M12;
			if (!true)
			{
			}
			float m5 = matrix1.M11;
			float m6 = matrix1.M12;
			float m7 = matrix1.M13;
			float m8 = matrix1.M14;
			result.M11 = m5;
			result.M12 = m6;
			float m9 = matrix1.M12;
			result.M13 = m7;
			float m10 = matrix1.M13;
			float m11 = matrix1.M21;
			float m12 = matrix1.M22;
			float m13 = matrix1.M23;
			float m14 = matrix1.M24;
			result.M21 = m11;
			float m15 = matrix1.M21;
			result.M22 = m12;
			float m16 = matrix1.M22;
			result.M23 = m13;
			float m17 = matrix1.M23;
			result.M24 = m15;
			float m18 = matrix1.M31;
			float m19 = matrix1.M32;
			float m20 = matrix1.M33;
			float m21 = matrix1.M34;
			result.M31 = m18;
			float m22 = matrix1.M31;
			result.M32 = m19;
			float m23 = matrix1.M32;
			result.M33 = m20;
			float m24 = matrix1.M33;
			result.M34 = m22;
			float m25 = matrix1.M41;
			float m26 = matrix1.M42;
			float m27 = matrix1.M43;
			float m28 = matrix1.M44;
			float m29 = matrix1.M41;
			float m30 = matrix1.M42;
			float m31 = matrix1.M43;
		}

		// Token: 0x060012EC RID: 4844 RVA: 0x0005B008 File Offset: 0x00059208
		public static Matrix Divide(Matrix matrix1, float divider)
		{
			float m = matrix1.M11;
			float m2 = matrix1.M12;
			float m3 = matrix1.M31;
			float m4 = matrix1.M32;
			matrix1.M11 = m;
			matrix1.M12 = m2;
			matrix1.M31 = m3;
			matrix1.M32 = divider;
			float m5 = matrix1.M31;
			float m6 = matrix1.M32;
			float m7 = matrix1.M11;
			float m8 = matrix1.M12;
			Matrix matrix2;
			matrix2.M31 = m5;
			matrix2.M32 = m6;
			matrix2.M11 = m7;
			matrix2.M12 = m8;
			return matrix2;
		}

		// Token: 0x060012ED RID: 4845 RVA: 0x0005B090 File Offset: 0x00059290
		public static void Divide(Matrix matrix1, float divider, [Out] Matrix result)
		{
			float m = matrix1.M21;
			result.M21 = m;
			float m2 = matrix1.M31;
			result.M31 = m2;
			float m3 = matrix1.M41;
			result.M41 = divider;
		}

		// Token: 0x060012EE RID: 4846 RVA: 0x0005B0C8 File Offset: 0x000592C8
		public static Matrix Invert(Matrix matrix)
		{
			if (!true)
			{
			}
			Matrix.Invert(matrix, matrix);
			float m = matrix.M31;
			float m2 = matrix.M32;
			float m3 = matrix.M11;
			float m4 = matrix.M12;
			Matrix matrix2;
			matrix2.M31 = m;
			matrix2.M32 = m2;
			matrix2.M11 = m3;
			matrix2.M12 = m4;
			return 1;
		}

		// Token: 0x060012EF RID: 4847 RVA: 0x0005B11C File Offset: 0x0005931C
		public static void Invert(Matrix matrix, [Out] Matrix result)
		{
			float m = matrix.M21;
			float m2 = matrix.M22;
			float m3 = matrix.M11;
			float m4 = matrix.M12;
			float m5 = matrix.M23;
			float m6 = matrix.M24;
			float m7 = matrix.M13;
			float m8 = matrix.M14;
			float m9 = matrix.M41;
			float m10 = matrix.M42;
			float m11 = matrix.M31;
			float m12 = matrix.M32;
			float m13 = matrix.M43;
			float m14 = matrix.M44;
			float m15 = matrix.M33;
			float m16 = matrix.M34;
			result.M11 = m2;
			result.M12 = m5;
			result.M13 = m3;
			result.M14 = m6;
			result.M21 = m11;
			result.M22 = m7;
			result.M23 = m16;
			result.M24 = m4;
			result.M31 = m;
			result.M32 = m15;
			result.M34 = m10;
			result.M41 = m12;
			result.M43 = m9;
			result.M44 = m14;
		}

		// Token: 0x060012F0 RID: 4848 RVA: 0x000021DB File Offset: 0x000003DB
		public static Matrix Lerp(Matrix matrix1, Matrix matrix2, float amount)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060012F1 RID: 4849 RVA: 0x000021DB File Offset: 0x000003DB
		public static void Lerp(Matrix matrix1, Matrix matrix2, float amount, [Out] Matrix result)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060012F2 RID: 4850 RVA: 0x0005B214 File Offset: 0x00059414
		public static Matrix Multiply(Matrix matrix1, Matrix matrix2)
		{
			float m = matrix1.M21;
			float m2 = matrix1.M13;
			float m3 = matrix1.M14;
			float m4 = matrix2.M31;
			float m5 = matrix2.M32;
			float m6 = matrix1.M23;
			float m7 = matrix1.M24;
			float m8 = matrix1.M31;
			float m9 = matrix1.M33;
			float m10 = matrix1.M34;
			float m11 = matrix1.M41;
			float m12 = matrix1.M43;
			float m13 = matrix1.M44;
			Matrix matrix3;
			matrix3.M31 = m4;
			return matrix3;
		}

		// Token: 0x060012F3 RID: 4851 RVA: 0x0005B290 File Offset: 0x00059490
		public static void Multiply(Matrix matrix1, Matrix matrix2, [Out] Matrix result)
		{
			float m = matrix1.M11;
			float m2 = matrix1.M12;
			float m3 = matrix2.M21;
			float m4 = matrix2.M31;
			float m5 = matrix1.M13;
			float m6 = matrix1.M14;
			float m7 = matrix2.M41;
			float m8 = matrix2.M12;
			float m9 = matrix2.M22;
			float m10 = matrix2.M32;
			float m11 = matrix2.M42;
			result.M12 = m8;
			float m12 = matrix2.M13;
			float m13 = matrix1.M12;
			float m14 = matrix2.M23;
			float m15 = matrix2.M33;
			float m16 = matrix2.M43;
			result.M13 = m12;
			float m17 = matrix2.M14;
			float m18 = matrix2.M24;
			float m19 = matrix1.M13;
			float m20 = matrix2.M34;
			float m21 = matrix2.M44;
			result.M14 = m6;
			float m22 = matrix1.M21;
			float m23 = matrix1.M22;
			float m24 = matrix1.M23;
			float m25 = matrix1.M24;
			result.M21 = m3;
			float m26 = matrix1.M21;
			float m27 = matrix2.M12;
			result.M22 = m3;
			float m28 = matrix2.M13;
			float m29 = matrix1.M22;
			result.M23 = m9;
			float m30 = matrix2.M14;
			float m31 = matrix1.M23;
			result.M24 = m29;
			float m32 = matrix1.M31;
			float m33 = matrix1.M32;
			float m34 = matrix2.M21;
			float m35 = matrix1.M33;
			float m36 = matrix1.M34;
			result.M31 = m4;
			float m37 = matrix1.M31;
			float m38 = matrix2.M22;
			result.M32 = m10;
			float m39 = matrix1.M32;
			float m40 = matrix2.M23;
			result.M33 = m15;
			float m41 = matrix2.M24;
			float m42 = matrix1.M33;
			result.M34 = m37;
			float m43 = matrix1.M41;
			float m44 = matrix1.M42;
			float m45 = matrix2.M31;
			float m46 = matrix1.M43;
			float m47 = matrix1.M44;
			result.M41 = m7;
			float m48 = matrix1.M41;
			float m49 = matrix2.M32;
			result.M42 = m11;
			float m50 = matrix1.M42;
			float m51 = matrix2.M33;
			result.M43 = m16;
			float m52 = matrix1.M43;
			float m53 = matrix2.M34;
			result.M44 = m48;
		}

		// Token: 0x060012F4 RID: 4852 RVA: 0x0005B4B8 File Offset: 0x000596B8
		public static Matrix Multiply(Matrix matrix1, float factor)
		{
			float m = matrix1.M11;
			float m2 = matrix1.M12;
			float m3 = matrix1.M31;
			float m4 = matrix1.M32;
			matrix1.M11 = m;
			matrix1.M12 = m2;
			matrix1.M31 = m3;
			matrix1.M32 = factor;
			float m5 = matrix1.M31;
			float m6 = matrix1.M32;
			float m7 = matrix1.M11;
			float m8 = matrix1.M12;
			Matrix matrix2;
			matrix2.M31 = m5;
			matrix2.M32 = m6;
			matrix2.M11 = m7;
			matrix2.M12 = m8;
			return matrix2;
		}

		// Token: 0x060012F5 RID: 4853 RVA: 0x0005B540 File Offset: 0x00059740
		public static void Multiply(Matrix matrix1, float factor, [Out] Matrix result)
		{
			float m = matrix1.M21;
			result.M21 = m;
			float m2 = matrix1.M31;
			result.M31 = m2;
			float m3 = matrix1.M41;
			result.M41 = factor;
		}

		// Token: 0x060012F6 RID: 4854 RVA: 0x0005B578 File Offset: 0x00059778
		public static Matrix Negate(Matrix matrix)
		{
			float m = matrix.M11;
			float m2 = matrix.M12;
			float m3 = matrix.M31;
			float m4 = matrix.M32;
			matrix.M11 = m;
			matrix.M12 = m2;
			matrix.M31 = m3;
			matrix.M32 = m4;
			float m5 = matrix.M31;
			float m6 = matrix.M32;
			float m7 = matrix.M11;
			float m8 = matrix.M12;
			Matrix matrix2;
			matrix2.M31 = m5;
			matrix2.M32 = m6;
			matrix2.M11 = m7;
			matrix2.M12 = m8;
			return matrix2;
		}

		// Token: 0x060012F7 RID: 4855 RVA: 0x0005B600 File Offset: 0x00059800
		public static void Negate(Matrix matrix, [Out] Matrix result)
		{
			float m = matrix.M21;
			result.M21 = m;
			float m2 = matrix.M31;
			result.M31 = m2;
			float m3 = matrix.M41;
			result.M41 = m3;
		}

		// Token: 0x060012F8 RID: 4856 RVA: 0x0005B638 File Offset: 0x00059838
		public static Matrix Subtract(Matrix matrix1, Matrix matrix2)
		{
			float m = matrix1.M11;
			float m2 = matrix1.M12;
			float m3 = matrix2.M12;
			matrix1.M12 = m3;
			float m4 = matrix2.M13;
			float m5 = matrix1.M13;
			float m6 = matrix1.M14;
			matrix1.M13 = m4;
			float m7 = matrix2.M14;
			matrix1.M14 = m7;
			float m8 = matrix2.M21;
			float m9 = matrix1.M21;
			float m10 = matrix1.M22;
			matrix1.M21 = m8;
			float m11 = matrix2.M22;
			matrix1.M22 = m11;
			float m12 = matrix2.M23;
			float m13 = matrix1.M23;
			float m14 = matrix1.M24;
			matrix1.M23 = m12;
			float m15 = matrix2.M24;
			matrix1.M24 = m15;
			float m16 = matrix2.M31;
			float m17 = matrix1.M31;
			float m18 = matrix1.M32;
			matrix1.M31 = m16;
			float m19 = matrix2.M32;
			matrix1.M32 = m19;
			float m20 = matrix2.M33;
			float m21 = matrix1.M33;
			float m22 = matrix1.M34;
			matrix1.M33 = m20;
			float m23 = matrix2.M34;
			matrix1.M34 = m23;
			float m24 = matrix2.M41;
			float m25 = matrix1.M41;
			float m26 = matrix1.M42;
			matrix1.M41 = m24;
			float m27 = matrix2.M42;
			matrix1.M42 = m27;
			float m28 = matrix2.M43;
			float m29 = matrix1.M43;
			float m30 = matrix1.M44;
			matrix1.M43 = m28;
			float m31 = matrix2.M44;
			matrix1.M44 = m31;
			float m32 = matrix1.M31;
			float m33 = matrix1.M32;
			float m34 = matrix1.M11;
			float m35 = matrix1.M12;
			Matrix matrix3;
			matrix3.M31 = m32;
			matrix3.M32 = m33;
			matrix3.M11 = m34;
			matrix3.M12 = m35;
			return matrix3;
		}

		// Token: 0x060012F9 RID: 4857 RVA: 0x0005B7F4 File Offset: 0x000599F4
		public static void Subtract(Matrix matrix1, Matrix matrix2, [Out] Matrix result)
		{
			float m = matrix1.M21;
			float m2 = matrix2.M21;
			result.M21 = m;
			float m3 = matrix1.M31;
			float m4 = matrix2.M31;
			result.M31 = m3;
			float m5 = matrix1.M41;
			float m6 = matrix2.M41;
			result.M41 = m5;
		}

		// Token: 0x060012FA RID: 4858 RVA: 0x0005B844 File Offset: 0x00059A44
		public static Matrix Transpose(Matrix matrix)
		{
			float m = matrix.M11;
			float m2 = matrix.M13;
			float m3 = matrix.M21;
			float m4 = matrix.M23;
			float m5 = matrix.M31;
			float m6 = matrix.M33;
			float m7 = matrix.M41;
			float m8 = matrix.M43;
			float m9 = matrix.M13;
			float m10 = matrix.M21;
			float m11 = matrix.M23;
			float m12 = matrix.M31;
			float m13 = matrix.M33;
			float m14 = matrix.M41;
			float m15 = matrix.M43;
			Matrix matrix2;
			matrix2.M11 = m;
			matrix2.M13 = m3;
			matrix2.M13 = m5;
			matrix2.M21 = m7;
			matrix2.M21 = m2;
			matrix2.M23 = m4;
			matrix2.M23 = m6;
			matrix2.M31 = m8;
			matrix2.M31 = m9;
			matrix2.M33 = m11;
			matrix2.M33 = m13;
			matrix2.M41 = m15;
			matrix2.M41 = m10;
			matrix2.M43 = m12;
			matrix2.M43 = m14;
			return matrix2;
		}

		// Token: 0x060012FB RID: 4859 RVA: 0x0005B93C File Offset: 0x00059B3C
		public static void Transpose(Matrix matrix, [Out] Matrix result)
		{
			float m = matrix.M21;
			result.M12 = m;
			float m2 = matrix.M31;
			result.M13 = m2;
			float m3 = matrix.M41;
			result.M14 = m3;
			float m4 = matrix.M12;
			result.M21 = m4;
			float m5 = matrix.M22;
			result.M22 = m5;
			float m6 = matrix.M32;
			result.M23 = m6;
			float m7 = matrix.M42;
			result.M24 = m7;
			float m8 = matrix.M13;
			result.M31 = m8;
			float m9 = matrix.M23;
			result.M32 = m9;
			float m10 = matrix.M33;
			result.M33 = m10;
			float m11 = matrix.M43;
			result.M34 = m11;
			float m12 = matrix.M14;
			result.M41 = m12;
			float m13 = matrix.M24;
			result.M42 = m13;
			float m14 = matrix.M34;
			result.M43 = m14;
			float m15 = matrix.M44;
			result.M44 = m15;
		}

		// Token: 0x060012FC RID: 4860 RVA: 0x0005BA34 File Offset: 0x00059C34
		public float Determinant()
		{
			/*
An exception occurred when decompiling this method (060012FC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Microsoft.Xna.Framework.Matrix::Determinant()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(Matrix::M31, ldloc:valuetype Microsoft.Xna.Framework.Matrix&(this)))
	stloc:float32(var_1_0D, ldfld:float32(Matrix::M41, ldloc:valuetype Microsoft.Xna.Framework.Matrix&(this)))
	stloc:float32(var_2_14, ldfld:float32(Matrix::M43, ldloc:valuetype Microsoft.Xna.Framework.Matrix&(this)))
	stloc:float32(var_3_1B, ldfld:float32(Matrix::M44, ldloc:valuetype Microsoft.Xna.Framework.Matrix&(this)))
	stloc:float32(var_4_22, ldfld:float32(Matrix::M33, ldloc:valuetype Microsoft.Xna.Framework.Matrix&(this)))
	stloc:float32(var_5_2A, ldfld:float32(Matrix::M34, ldloc:valuetype Microsoft.Xna.Framework.Matrix&(this)))
	stloc:float32(var_6_32, ldfld:float32(Matrix::M23, ldloc:valuetype Microsoft.Xna.Framework.Matrix&(this)))
	stloc:float32(var_7_3A, ldfld:float32(Matrix::M24, ldloc:valuetype Microsoft.Xna.Framework.Matrix&(this)))
	stloc:float32(var_8_42, ldfld:float32(Matrix::M21, ldloc:valuetype Microsoft.Xna.Framework.Matrix&(this)))
	stloc:float32(var_9_4A, ldfld:float32(Matrix::M13, ldloc:valuetype Microsoft.Xna.Framework.Matrix&(this)))
	stloc:float32(var_10_52, ldfld:float32(Matrix::M14, ldloc:valuetype Microsoft.Xna.Framework.Matrix&(this)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x060012FD RID: 4861 RVA: 0x0005BA94 File Offset: 0x00059C94
		public bool Equals(Matrix other)
		{
			/*
An exception occurred when decompiling this method (060012FD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Microsoft.Xna.Framework.Matrix::Equals(Microsoft.Xna.Framework.Matrix)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(Matrix::M12, ldloc:valuetype Microsoft.Xna.Framework.Matrix&(this)))
	stloc:float32(var_1_0D, ldfld:float32(Matrix::M12, ldloc:Matrix[exp:valuetype Microsoft.Xna.Framework.Matrix&](other)))
	stloc:float32(var_2_14, ldfld:float32(Matrix::M13, ldloc:valuetype Microsoft.Xna.Framework.Matrix&(this)))
	stloc:float32(var_3_1B, ldfld:float32(Matrix::M13, ldloc:Matrix[exp:valuetype Microsoft.Xna.Framework.Matrix&](other)))
	stloc:float32(var_4_22, ldfld:float32(Matrix::M14, ldloc:valuetype Microsoft.Xna.Framework.Matrix&(this)))
	stloc:float32(var_5_2A, ldfld:float32(Matrix::M14, ldloc:Matrix[exp:valuetype Microsoft.Xna.Framework.Matrix&](other)))
	stloc:float32(var_6_32, ldfld:float32(Matrix::M21, ldloc:valuetype Microsoft.Xna.Framework.Matrix&(this)))
	stloc:float32(var_7_3A, ldfld:float32(Matrix::M21, ldloc:Matrix[exp:valuetype Microsoft.Xna.Framework.Matrix&](other)))
	stloc:float32(var_8_42, ldfld:float32(Matrix::M22, ldloc:valuetype Microsoft.Xna.Framework.Matrix&(this)))
	stloc:float32(var_9_4A, ldfld:float32(Matrix::M22, ldloc:Matrix[exp:valuetype Microsoft.Xna.Framework.Matrix&](other)))
	stloc:float32(var_10_52, ldfld:float32(Matrix::M23, ldloc:valuetype Microsoft.Xna.Framework.Matrix&(this)))
	stloc:float32(var_11_5A, ldfld:float32(Matrix::M23, ldloc:Matrix[exp:valuetype Microsoft.Xna.Framework.Matrix&](other)))
	stloc:float32(var_12_62, ldfld:float32(Matrix::M24, ldloc:valuetype Microsoft.Xna.Framework.Matrix&(this)))
	stloc:float32(var_13_6A, ldfld:float32(Matrix::M24, ldloc:Matrix[exp:valuetype Microsoft.Xna.Framework.Matrix&](other)))
	stloc:float32(var_14_72, ldfld:float32(Matrix::M31, ldloc:valuetype Microsoft.Xna.Framework.Matrix&(this)))
	stloc:float32(var_15_7A, ldfld:float32(Matrix::M31, ldloc:Matrix[exp:valuetype Microsoft.Xna.Framework.Matrix&](other)))
	stloc:float32(var_16_82, ldfld:float32(Matrix::M32, ldloc:valuetype Microsoft.Xna.Framework.Matrix&(this)))
	stloc:float32(var_17_8A, ldfld:float32(Matrix::M32, ldloc:Matrix[exp:valuetype Microsoft.Xna.Framework.Matrix&](other)))
	stloc:float32(var_18_92, ldfld:float32(Matrix::M33, ldloc:valuetype Microsoft.Xna.Framework.Matrix&(this)))
	stloc:float32(var_19_9A, ldfld:float32(Matrix::M33, ldloc:Matrix[exp:valuetype Microsoft.Xna.Framework.Matrix&](other)))
	stloc:float32(var_20_A2, ldfld:float32(Matrix::M34, ldloc:valuetype Microsoft.Xna.Framework.Matrix&(this)))
	stloc:float32(var_21_AA, ldfld:float32(Matrix::M34, ldloc:Matrix[exp:valuetype Microsoft.Xna.Framework.Matrix&](other)))
	stloc:float32(var_22_B2, ldfld:float32(Matrix::M41, ldloc:valuetype Microsoft.Xna.Framework.Matrix&(this)))
	stloc:float32(var_23_BA, ldfld:float32(Matrix::M41, ldloc:Matrix[exp:valuetype Microsoft.Xna.Framework.Matrix&](other)))
	stloc:float32(var_24_C2, ldfld:float32(Matrix::M42, ldloc:valuetype Microsoft.Xna.Framework.Matrix&(this)))
	stloc:float32(var_25_CA, ldfld:float32(Matrix::M42, ldloc:Matrix[exp:valuetype Microsoft.Xna.Framework.Matrix&](other)))
	stloc:float32(var_26_D2, ldfld:float32(Matrix::M43, ldloc:valuetype Microsoft.Xna.Framework.Matrix&(this)))
	stloc:float32(var_27_DA, ldfld:float32(Matrix::M43, ldloc:Matrix[exp:valuetype Microsoft.Xna.Framework.Matrix&](other)))
	stloc:float32(var_28_E2, ldfld:float32(Matrix::M44, ldloc:valuetype Microsoft.Xna.Framework.Matrix&(this)))
	stloc:float32(var_29_EA, ldfld:float32(Matrix::M44, ldloc:Matrix[exp:valuetype Microsoft.Xna.Framework.Matrix&](other)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x060012FE RID: 4862 RVA: 0x0005BB90 File Offset: 0x00059D90
		public static Matrix operator +(Matrix matrix1, Matrix matrix2)
		{
			float m = matrix1.M11;
			float m2 = matrix1.M12;
			float m3 = matrix2.M12;
			matrix1.M12 = m3;
			float m4 = matrix2.M13;
			float m5 = matrix1.M13;
			float m6 = matrix1.M14;
			matrix1.M13 = m4;
			float m7 = matrix2.M14;
			matrix1.M14 = m7;
			float m8 = matrix2.M21;
			float m9 = matrix1.M21;
			float m10 = matrix1.M22;
			matrix1.M21 = m8;
			float m11 = matrix2.M22;
			matrix1.M22 = m11;
			float m12 = matrix2.M23;
			float m13 = matrix1.M23;
			float m14 = matrix1.M24;
			matrix1.M23 = m12;
			float m15 = matrix2.M24;
			matrix1.M24 = m15;
			float m16 = matrix2.M31;
			float m17 = matrix1.M31;
			float m18 = matrix1.M32;
			matrix1.M31 = m16;
			float m19 = matrix2.M32;
			matrix1.M32 = m19;
			float m20 = matrix2.M33;
			float m21 = matrix1.M33;
			float m22 = matrix1.M34;
			matrix1.M33 = m20;
			float m23 = matrix2.M34;
			matrix1.M34 = m23;
			float m24 = matrix2.M41;
			float m25 = matrix1.M41;
			float m26 = matrix1.M42;
			matrix1.M41 = m24;
			float m27 = matrix2.M42;
			matrix1.M42 = m27;
			float m28 = matrix2.M43;
			float m29 = matrix1.M43;
			float m30 = matrix1.M44;
			matrix1.M43 = m28;
			float m31 = matrix2.M44;
			matrix1.M44 = m31;
			float m32 = matrix1.M31;
			float m33 = matrix1.M32;
			float m34 = matrix1.M11;
			float m35 = matrix1.M12;
			Matrix matrix3;
			matrix3.M31 = m32;
			matrix3.M32 = m33;
			matrix3.M11 = m34;
			matrix3.M12 = m35;
			return matrix3;
		}

		// Token: 0x060012FF RID: 4863 RVA: 0x0005BD4C File Offset: 0x00059F4C
		public static Matrix operator /(Matrix matrix1, Matrix matrix2)
		{
			float m = matrix2.M31;
			float m2 = matrix2.M32;
			float m3 = matrix2.M11;
			float m4 = matrix2.M12;
			if (!true)
			{
			}
			float m5 = matrix1.M13;
			float m6 = matrix1.M14;
			float m7 = matrix1.M21;
			float m8 = matrix1.M22;
			float m9 = matrix1.M23;
			float m10 = matrix1.M24;
			float m11 = matrix1.M31;
			float m12 = matrix1.M32;
			float m13 = matrix1.M33;
			float m14 = matrix1.M34;
			float m15 = matrix1.M41;
			float m16 = matrix1.M42;
			float m17 = matrix1.M43;
			float m18 = matrix1.M44;
			Matrix matrix3;
			matrix3.M11 = m2;
			matrix3.M12 = m;
			matrix3.M42 = m3;
			return matrix1;
		}

		// Token: 0x06001300 RID: 4864 RVA: 0x0005BE00 File Offset: 0x0005A000
		public static Matrix operator /(Matrix matrix1, float divider)
		{
			float m = matrix1.M11;
			float m2 = matrix1.M12;
			float m3 = matrix1.M31;
			float m4 = matrix1.M32;
			matrix1.M11 = m;
			matrix1.M12 = m2;
			matrix1.M31 = m3;
			matrix1.M32 = divider;
			float m5 = matrix1.M31;
			float m6 = matrix1.M32;
			float m7 = matrix1.M11;
			float m8 = matrix1.M12;
			Matrix matrix2;
			matrix2.M31 = m5;
			matrix2.M32 = m6;
			matrix2.M11 = m7;
			matrix2.M12 = m8;
			return matrix2;
		}

		// Token: 0x06001301 RID: 4865 RVA: 0x0005BE88 File Offset: 0x0005A088
		public static bool operator ==(Matrix matrix1, Matrix matrix2)
		{
			/*
An exception occurred when decompiling this method (06001301)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Microsoft.Xna.Framework.Matrix::op_Equality(Microsoft.Xna.Framework.Matrix,Microsoft.Xna.Framework.Matrix)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(Matrix::M12, ldloc:Matrix[exp:valuetype Microsoft.Xna.Framework.Matrix&](matrix1)))
	stloc:float32(var_1_0D, ldfld:float32(Matrix::M13, ldloc:Matrix[exp:valuetype Microsoft.Xna.Framework.Matrix&](matrix1)))
	stloc:float32(var_2_14, ldfld:float32(Matrix::M14, ldloc:Matrix[exp:valuetype Microsoft.Xna.Framework.Matrix&](matrix1)))
	stloc:float32(var_3_1B, ldfld:float32(Matrix::M21, ldloc:Matrix[exp:valuetype Microsoft.Xna.Framework.Matrix&](matrix1)))
	stloc:float32(var_4_22, ldfld:float32(Matrix::M22, ldloc:Matrix[exp:valuetype Microsoft.Xna.Framework.Matrix&](matrix1)))
	stloc:float32(var_5_2A, ldfld:float32(Matrix::M23, ldloc:Matrix[exp:valuetype Microsoft.Xna.Framework.Matrix&](matrix1)))
	stloc:float32(var_6_32, ldfld:float32(Matrix::M24, ldloc:Matrix[exp:valuetype Microsoft.Xna.Framework.Matrix&](matrix1)))
	stloc:float32(var_7_3A, ldfld:float32(Matrix::M31, ldloc:Matrix[exp:valuetype Microsoft.Xna.Framework.Matrix&](matrix1)))
	stloc:float32(var_8_42, ldfld:float32(Matrix::M32, ldloc:Matrix[exp:valuetype Microsoft.Xna.Framework.Matrix&](matrix1)))
	stloc:float32(var_9_4A, ldfld:float32(Matrix::M33, ldloc:Matrix[exp:valuetype Microsoft.Xna.Framework.Matrix&](matrix1)))
	stloc:float32(var_10_52, ldfld:float32(Matrix::M34, ldloc:Matrix[exp:valuetype Microsoft.Xna.Framework.Matrix&](matrix1)))
	stloc:float32(var_11_5A, ldfld:float32(Matrix::M41, ldloc:Matrix[exp:valuetype Microsoft.Xna.Framework.Matrix&](matrix1)))
	stloc:float32(var_12_62, ldfld:float32(Matrix::M42, ldloc:Matrix[exp:valuetype Microsoft.Xna.Framework.Matrix&](matrix1)))
	stloc:float32(var_13_6A, ldfld:float32(Matrix::M43, ldloc:Matrix[exp:valuetype Microsoft.Xna.Framework.Matrix&](matrix1)))
	stloc:float32(var_14_72, ldfld:float32(Matrix::M44, ldloc:Matrix[exp:valuetype Microsoft.Xna.Framework.Matrix&](matrix1)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x06001302 RID: 4866 RVA: 0x0005BF0C File Offset: 0x0005A10C
		public static bool operator !=(Matrix matrix1, Matrix matrix2)
		{
			float m = matrix1.M12;
			float m2 = matrix1.M13;
			float m3 = matrix1.M14;
			float m4 = matrix1.M21;
			float m5 = matrix1.M22;
			float m6 = matrix1.M23;
			float m7 = matrix1.M24;
			float m8 = matrix1.M31;
			float m9 = matrix1.M32;
			float m10 = matrix1.M33;
			float m11 = matrix1.M34;
			float m12 = matrix1.M41;
			float m13 = matrix1.M42;
			float m14 = matrix1.M43;
			float m15 = matrix1.M44;
			return true;
		}

		// Token: 0x06001303 RID: 4867 RVA: 0x0005BF90 File Offset: 0x0005A190
		public static Matrix operator *(Matrix matrix1, Matrix matrix2)
		{
			float m = matrix1.M21;
			float m2 = matrix1.M13;
			float m3 = matrix1.M14;
			float m4 = matrix2.M31;
			float m5 = matrix2.M32;
			float m6 = matrix1.M23;
			float m7 = matrix1.M24;
			float m8 = matrix1.M31;
			float m9 = matrix1.M33;
			float m10 = matrix1.M34;
			float m11 = matrix1.M41;
			float m12 = matrix1.M43;
			float m13 = matrix1.M44;
			Matrix matrix3;
			matrix3.M31 = m4;
			return matrix3;
		}

		// Token: 0x06001304 RID: 4868 RVA: 0x0005C00C File Offset: 0x0005A20C
		public static Matrix operator *(Matrix matrix, float scaleFactor)
		{
			float m = matrix.M11;
			float m2 = matrix.M12;
			float m3 = matrix.M31;
			float m4 = matrix.M32;
			matrix.M11 = m;
			matrix.M12 = m2;
			matrix.M31 = m3;
			matrix.M32 = scaleFactor;
			float m5 = matrix.M31;
			float m6 = matrix.M32;
			float m7 = matrix.M11;
			float m8 = matrix.M12;
			Matrix matrix2;
			matrix2.M31 = m5;
			matrix2.M32 = m6;
			matrix2.M11 = m7;
			matrix2.M12 = m8;
			return matrix2;
		}

		// Token: 0x06001305 RID: 4869 RVA: 0x0005C094 File Offset: 0x0005A294
		public static Matrix operator *(float scaleFactor, Matrix matrix)
		{
			float m = matrix.M11;
			float m2 = matrix.M12;
			float m3 = matrix.M31;
			float m4 = matrix.M32;
			matrix.M11 = m;
			matrix.M12 = m2;
			matrix.M31 = m3;
			matrix.M32 = scaleFactor;
			float m5 = matrix.M31;
			float m6 = matrix.M32;
			float m7 = matrix.M11;
			float m8 = matrix.M12;
			Matrix matrix2;
			matrix2.M31 = m5;
			matrix2.M32 = m6;
			matrix2.M11 = m7;
			matrix2.M12 = m8;
			return matrix2;
		}

		// Token: 0x06001306 RID: 4870 RVA: 0x0005C11C File Offset: 0x0005A31C
		public static Matrix operator -(Matrix matrix1, Matrix matrix2)
		{
			float m = matrix1.M11;
			float m2 = matrix1.M12;
			float m3 = matrix2.M12;
			matrix1.M12 = m3;
			float m4 = matrix2.M13;
			float m5 = matrix1.M13;
			float m6 = matrix1.M14;
			matrix1.M13 = m4;
			float m7 = matrix2.M14;
			matrix1.M14 = m7;
			float m8 = matrix2.M21;
			float m9 = matrix1.M21;
			float m10 = matrix1.M22;
			matrix1.M21 = m8;
			float m11 = matrix2.M22;
			matrix1.M22 = m11;
			float m12 = matrix2.M23;
			float m13 = matrix1.M23;
			float m14 = matrix1.M24;
			matrix1.M23 = m12;
			float m15 = matrix2.M24;
			matrix1.M24 = m15;
			float m16 = matrix2.M31;
			float m17 = matrix1.M31;
			float m18 = matrix1.M32;
			matrix1.M31 = m16;
			float m19 = matrix2.M32;
			matrix1.M32 = m19;
			float m20 = matrix2.M33;
			float m21 = matrix1.M33;
			float m22 = matrix1.M34;
			matrix1.M33 = m20;
			float m23 = matrix2.M34;
			matrix1.M34 = m23;
			float m24 = matrix2.M41;
			float m25 = matrix1.M41;
			float m26 = matrix1.M42;
			matrix1.M41 = m24;
			float m27 = matrix2.M42;
			matrix1.M42 = m27;
			float m28 = matrix2.M43;
			float m29 = matrix1.M43;
			float m30 = matrix1.M44;
			matrix1.M43 = m28;
			float m31 = matrix2.M44;
			matrix1.M44 = m31;
			float m32 = matrix1.M31;
			float m33 = matrix1.M32;
			float m34 = matrix1.M11;
			float m35 = matrix1.M12;
			Matrix matrix3;
			matrix3.M31 = m32;
			matrix3.M32 = m33;
			matrix3.M11 = m34;
			matrix3.M12 = m35;
			return matrix3;
		}

		// Token: 0x06001307 RID: 4871 RVA: 0x0005C2D8 File Offset: 0x0005A4D8
		public static Matrix operator -(Matrix matrix)
		{
			float m = matrix.M11;
			float m2 = matrix.M12;
			float m3 = matrix.M31;
			float m4 = matrix.M32;
			matrix.M11 = m;
			matrix.M12 = m2;
			matrix.M31 = m3;
			matrix.M32 = m4;
			float m5 = matrix.M31;
			float m6 = matrix.M32;
			float m7 = matrix.M11;
			float m8 = matrix.M12;
			Matrix matrix2;
			matrix2.M31 = m5;
			matrix2.M32 = m6;
			matrix2.M11 = m7;
			matrix2.M12 = m8;
			return matrix2;
		}

		// Token: 0x06001308 RID: 4872 RVA: 0x0005C360 File Offset: 0x0005A560
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
			}
			float m = this.M31;
			float m2 = this.M32;
			float m3 = this.M11;
			float m4 = this.M12;
			bool flag;
			return flag;
		}

		// Token: 0x06001309 RID: 4873 RVA: 0x000021DB File Offset: 0x000003DB
		public override int GetHashCode()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600130A RID: 4874 RVA: 0x0005C398 File Offset: 0x0005A598
		public override string ToString()
		{
			string text;
			string text2;
			string text3;
			string text4;
			string text5;
			string text6;
			string text7;
			string text8;
			string text9;
			string text10;
			string text11;
			string text12;
			string text13;
			string text14;
			string text15;
			string text16;
			if (("{ {M11:" == null || "{ {M11:" != null) && (text == null || text != null) && (" M12:" == null || " M12:" != null) && (text2 == null || text2 != null) && (" M13:" == null || " M13:" != null) && (text3 == null || text3 != null) && (" M14:" == null || " M14:" != null) && (text4 == null || text4 != null) && ("} {M21:" == null || "} {M21:" != null) && (text5 == null || text5 != null) && (" M22:" == null || " M22:" != null) && (text6 == null || text6 != null) && (" M23:" == null || " M23:" != null) && (text7 == null || text7 != null) && (" M24:" == null || " M24:" != null) && (text8 == null || text8 != null) && ("} {M31:" == null || "} {M31:" != null) && (text9 == null || text9 != null) && (" M32:" == null || " M32:" != null) && (text10 == null || text10 != null) && (" M33:" == null || " M33:" != null) && (text11 == null || text11 != null) && (" M34:" == null || " M34:" != null) && (text12 == null || text12 != null) && ("} {M41:" == null || "} {M41:" != null) && (text13 == null || text13 != null) && (" M42:" == null || " M42:" != null) && (text14 == null || text14 != null) && (" M43:" == null || " M43:" != null) && (text15 == null || text15 != null) && (" M44:" == null || " M44:" != null) && (text16 == null || text16 != null) && ("} }" == null || "} }" != null))
			{
				string text17;
				return text17;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600130B RID: 4875 RVA: 0x0005C564 File Offset: 0x0005A764
		// Note: this type is marked as 'beforefieldinit'.
		static Matrix()
		{
		}

		// Token: 0x04002252 RID: 8786
		public float M11;

		// Token: 0x04002253 RID: 8787
		public float M12;

		// Token: 0x04002254 RID: 8788
		public float M13;

		// Token: 0x04002255 RID: 8789
		public float M14;

		// Token: 0x04002256 RID: 8790
		public float M21;

		// Token: 0x04002257 RID: 8791
		public float M22;

		// Token: 0x04002258 RID: 8792
		public float M23;

		// Token: 0x04002259 RID: 8793
		public float M24;

		// Token: 0x0400225A RID: 8794
		public float M31;

		// Token: 0x0400225B RID: 8795
		public float M32;

		// Token: 0x0400225C RID: 8796
		public float M33;

		// Token: 0x0400225D RID: 8797
		public float M34;

		// Token: 0x0400225E RID: 8798
		public float M41;

		// Token: 0x0400225F RID: 8799
		public float M42;

		// Token: 0x04002260 RID: 8800
		public float M43;

		// Token: 0x04002261 RID: 8801
		public float M44;

		// Token: 0x04002262 RID: 8802
		private static Matrix identity;
	}
}
