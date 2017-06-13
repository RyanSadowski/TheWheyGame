#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

// AutoFade
struct AutoFade_t3786508579;
// UnityEngine.Material
struct Material_t193706927;
// System.String
struct String_t;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// AutoFade
struct  AutoFade_t3786508579  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.Material AutoFade::m_Material
	Material_t193706927 * ___m_Material_3;
	// System.String AutoFade::m_LevelName
	String_t* ___m_LevelName_4;
	// System.Int32 AutoFade::m_LevelIndex
	int32_t ___m_LevelIndex_5;
	// System.Boolean AutoFade::m_Fading
	bool ___m_Fading_6;

public:
	inline static int32_t get_offset_of_m_Material_3() { return static_cast<int32_t>(offsetof(AutoFade_t3786508579, ___m_Material_3)); }
	inline Material_t193706927 * get_m_Material_3() const { return ___m_Material_3; }
	inline Material_t193706927 ** get_address_of_m_Material_3() { return &___m_Material_3; }
	inline void set_m_Material_3(Material_t193706927 * value)
	{
		___m_Material_3 = value;
		Il2CppCodeGenWriteBarrier(&___m_Material_3, value);
	}

	inline static int32_t get_offset_of_m_LevelName_4() { return static_cast<int32_t>(offsetof(AutoFade_t3786508579, ___m_LevelName_4)); }
	inline String_t* get_m_LevelName_4() const { return ___m_LevelName_4; }
	inline String_t** get_address_of_m_LevelName_4() { return &___m_LevelName_4; }
	inline void set_m_LevelName_4(String_t* value)
	{
		___m_LevelName_4 = value;
		Il2CppCodeGenWriteBarrier(&___m_LevelName_4, value);
	}

	inline static int32_t get_offset_of_m_LevelIndex_5() { return static_cast<int32_t>(offsetof(AutoFade_t3786508579, ___m_LevelIndex_5)); }
	inline int32_t get_m_LevelIndex_5() const { return ___m_LevelIndex_5; }
	inline int32_t* get_address_of_m_LevelIndex_5() { return &___m_LevelIndex_5; }
	inline void set_m_LevelIndex_5(int32_t value)
	{
		___m_LevelIndex_5 = value;
	}

	inline static int32_t get_offset_of_m_Fading_6() { return static_cast<int32_t>(offsetof(AutoFade_t3786508579, ___m_Fading_6)); }
	inline bool get_m_Fading_6() const { return ___m_Fading_6; }
	inline bool* get_address_of_m_Fading_6() { return &___m_Fading_6; }
	inline void set_m_Fading_6(bool value)
	{
		___m_Fading_6 = value;
	}
};

struct AutoFade_t3786508579_StaticFields
{
public:
	// AutoFade AutoFade::m_Instance
	AutoFade_t3786508579 * ___m_Instance_2;

public:
	inline static int32_t get_offset_of_m_Instance_2() { return static_cast<int32_t>(offsetof(AutoFade_t3786508579_StaticFields, ___m_Instance_2)); }
	inline AutoFade_t3786508579 * get_m_Instance_2() const { return ___m_Instance_2; }
	inline AutoFade_t3786508579 ** get_address_of_m_Instance_2() { return &___m_Instance_2; }
	inline void set_m_Instance_2(AutoFade_t3786508579 * value)
	{
		___m_Instance_2 = value;
		Il2CppCodeGenWriteBarrier(&___m_Instance_2, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
