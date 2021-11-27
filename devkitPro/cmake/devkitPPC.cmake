cmake_minimum_required(VERSION 3.7)
include(${CMAKE_CURRENT_LIST_DIR}/dkp-initialize-path.cmake)

set(devkitPPC TRUE)

set(CMAKE_SYSTEM_NAME Generic)
set(CMAKE_SYSTEM_VERSION 1)
set(CMAKE_SYSTEM_PROCESSOR "ppc")
set(CMAKE_CROSSCOMPILING 1)

set(TOOL_PREFIX ${DEVKITPRO}/devkitPPC/bin/powerpc-eabi-)

set(CMAKE_ASM_COMPILER ${TOOL_PREFIX}gcc    CACHE PATH "")
set(CMAKE_C_COMPILER   ${TOOL_PREFIX}gcc    CACHE PATH "")
set(CMAKE_CXX_COMPILER ${TOOL_PREFIX}g++    CACHE PATH "")
set(CMAKE_LINKER       ${TOOL_PREFIX}ld     CACHE PATH "")
set(CMAKE_AR           ${TOOL_PREFIX}ar     CACHE PATH "")
set(CMAKE_RANLIB       ${TOOL_PREFIX}ranlib CACHE PATH "")
set(CMAKE_STRIP        ${TOOL_PREFIX}strip  CACHE PATH "")

set(CMAKE_LIBRARY_ARCHITECTURE powerpc-eabi CACHE INTERNAL "abi")

set(CMAKE_FIND_ROOT_PATH_MODE_PROGRAM BOTH)
set(CMAKE_FIND_ROOT_PATH_MODE_LIBRARY ONLY)
set(CMAKE_FIND_ROOT_PATH_MODE_INCLUDE ONLY)
set(CMAKE_FIND_ROOT_PATH_MODE_PACKAGE ONLY)

set(BUILD_SHARED_LIBS OFF CACHE INTERNAL "Shared libs not available" )
