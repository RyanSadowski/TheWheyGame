#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

// UnityEngine.UI.Button
struct Button_t2872111280;
// UnityEngine.UI.Text
struct Text_t356221433;
// UnityEngine.UI.InputField
struct InputField_t1631627530;
// System.String
struct String_t;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// loginScript
struct  loginScript_t3521701410  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.UI.Button loginScript::button
	Button_t2872111280 * ___button_2;
	// UnityEngine.UI.Text loginScript::usernameField
	Text_t356221433 * ___usernameField_3;
	// UnityEngine.UI.InputField loginScript::passwordField
	InputField_t1631627530 * ___passwordField_4;
	// System.String loginScript::username
	String_t* ___username_5;
	// System.String loginScript::password
	String_t* ___password_6;
	// System.String loginScript::url
	String_t* ___url_7;

public:
	inline static int32_t get_offset_of_button_2() { return static_cast<int32_t>(offsetof(loginScript_t3521701410, ___button_2)); }
	inline Button_t2872111280 * get_button_2() const { return ___button_2; }
	inline Button_t2872111280 ** get_address_of_button_2() { return &___button_2; }
	inline void set_button_2(Button_t2872111280 * value)
	{
		___button_2 = value;
		Il2CppCodeGenWriteBarrier(&___button_2, value);
	}

	inline static int32_t get_offset_of_usernameField_3() { return static_cast<int32_t>(offsetof(loginScript_t3521701410, ___usernameField_3)); }
	inline Text_t356221433 * get_usernameField_3() const { return ___usernameField_3; }
	inline Text_t356221433 ** get_address_of_usernameField_3() { return &___usernameField_3; }
	inline void set_usernameField_3(Text_t356221433 * value)
	{
		___usernameField_3 = value;
		Il2CppCodeGenWriteBarrier(&___usernameField_3, value);
	}

	inline static int32_t get_offset_of_passwordField_4() { return static_cast<int32_t>(offsetof(loginScript_t3521701410, ___passwordField_4)); }
	inline InputField_t1631627530 * get_passwordField_4() const { return ___passwordField_4; }
	inline InputField_t1631627530 ** get_address_of_passwordField_4() { return &___passwordField_4; }
	inline void set_passwordField_4(InputField_t1631627530 * value)
	{
		___passwordField_4 = value;
		Il2CppCodeGenWriteBarrier(&___passwordField_4, value);
	}

	inline static int32_t get_offset_of_username_5() { return static_cast<int32_t>(offsetof(loginScript_t3521701410, ___username_5)); }
	inline String_t* get_username_5() const { return ___username_5; }
	inline String_t** get_address_of_username_5() { return &___username_5; }
	inline void set_username_5(String_t* value)
	{
		___username_5 = value;
		Il2CppCodeGenWriteBarrier(&___username_5, value);
	}

	inline static int32_t get_offset_of_password_6() { return static_cast<int32_t>(offsetof(loginScript_t3521701410, ___password_6)); }
	inline String_t* get_password_6() const { return ___password_6; }
	inline String_t** get_address_of_password_6() { return &___password_6; }
	inline void set_password_6(String_t* value)
	{
		___password_6 = value;
		Il2CppCodeGenWriteBarrier(&___password_6, value);
	}

	inline static int32_t get_offset_of_url_7() { return static_cast<int32_t>(offsetof(loginScript_t3521701410, ___url_7)); }
	inline String_t* get_url_7() const { return ___url_7; }
	inline String_t** get_address_of_url_7() { return &___url_7; }
	inline void set_url_7(String_t* value)
	{
		___url_7 = value;
		Il2CppCodeGenWriteBarrier(&___url_7, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
