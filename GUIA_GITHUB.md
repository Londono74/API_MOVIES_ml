# 🚀 GUÍA: SUBIR PROYECTO A GITHUB

## 📋 PASO 1: INSTALAR GIT

Si Git no está instalado en tu PC:

1. **Descarga Git:**
   - Ve a: https://git-scm.com/download/win
   - Descarga e instala Git para Windows

2. **Verifica la instalación:**
   - Abre PowerShell o CMD
   - Ejecuta: `git --version`
   - Deberías ver algo como: `git version 2.xx.x`

---

## 📋 PASO 2: CONFIGURAR GIT (Primera vez)

Si es la primera vez que usas Git en esta PC:

```bash
git config --global user.name "Tu Nombre"
git config --global user.email "tu-email@ejemplo.com"
```

**Ejemplo:**
```bash
git config --global user.name "Malp0"
git config --global user.email "malp0@ejemplo.com"
```

---

## 📋 PASO 3: NAVEGAR A LA CARPETA DEL PROYECTO

Abre PowerShell o CMD y navega a la carpeta del proyecto:

```bash
cd "C:\Users\malp0\Downloads\API Peliculas\API.W.Movies-master\API.W.Movies-master"
```

**O desde la carpeta actual:**
```bash
cd "API.W.Movies-master\API.W.Movies-master"
```

---

## 📋 PASO 4: INICIALIZAR REPOSITORIO GIT

Si la carpeta NO tiene Git inicializado:

```bash
git init
```

Esto crea una carpeta `.git` (oculta) que rastrea los cambios.

---

## 📋 PASO 5: CREAR ARCHIVO .gitignore (IMPORTANTE)

Crea un archivo `.gitignore` para NO subir archivos innecesarios:

**Crea el archivo `.gitignore` en la raíz del proyecto con este contenido:**

```
# Build results
[Dd]ebug/
[Dd]ebugPublic/
[Rr]elease/
[Rr]eleases/
x64/
x86/
[Aa][Rr][Mm]/
[Aa][Rr][Mm]64/
bld/
[Bb]in/
[Oo]bj/
[Ll]og/
[Ll]ogs/

# Visual Studio
.vs/
*.user
*.suo
*.userosscache
*.sln.docstates

# Rider
.idea/
*.sln.iml

# User-specific files
*.rsuser
*.suo
*.user
*.userosscache
*.sln.docstates

# .NET Core
project.lock.json
project.fragment.lock.json
artifacts/

# NuGet Packages
*.nupkg
*.snupkg
**/packages/*
!**/packages/build/

# Visual Studio cache
.vs/

# Build results
[Bb]in/
[Oo]bj/

# MSTest test Results
[Tt]est[Rr]esult*/
[Bb]uild[Ll]og.*

# .NET Core
project.lock.json
project.fragment.lock.json
artifacts/

# Files built by Visual Studio
*_i.c
*_p.c
*_h.h
*.ilk
*.meta
*.obj
*.iobj
*.pch
*.pdb
*.ipdb
*.pgc
*.pgd
*.rsp
*.sbr
*.tlb
*.tli
*.tlh
*.tmp
*.tmp_proj
*_wpftmp.csproj
*.log
*.vspscc
*.vssscc
.builds
*.pidb
*.svclog
*.scc

# Visual C++ cache files
ipch/
*.aps
*.ncb
*.opendb
*.opensdf
*.sdf
*.cachefile
*.VC.db
*.VC.VC.opendb

# Visual Studio profiler
*.psess
*.vsp
*.vspx
*.sap

# ReSharper
_ReSharper*/
*.[Rr]e[Ss]harper
*.DotSettings.user

# JetBrains Rider
.idea/
*.sln.iml

# CodeRush
.cr/

# Python Tools for Visual Studio (PTVS)
__pycache__/
*.pyc

# Cake
tools/**
!tools/packages.config

# Tabs Studio
*.tss

# Telerik's JustMock configuration file
*.jmconfig

# BizTalk build output
*.btp.cs
*.btm.cs
*.odx.cs
*.xsd.cs

# OpenCover UI analysis results
OpenCover/

# Azure Stream Analytics local run output
ASALocalRun/

# MSBuild Binary and Structured Log
*.binlog

# NVidia Nsight GPU debugger configuration file
*.nvuser

# MFractors (Xamarin productivity tool) working folder
.mfractor/

# Local History for Visual Studio
.localhistory/

# BeatPulse healthcheck temp db
healthchecksdb

# Backup folder for Package Reference Convert tool in Visual Studio 2017
MigrationBackup/

# Ionide (cross platform F# VS Code tools) working folder
.ionide/
```

---

## 📋 PASO 6: AGREGAR ARCHIVOS AL STAGING

Agrega todos los archivos del proyecto:

```bash
git add .
```

**O si quieres agregar archivos específicos:**
```bash
git add API.W.Movies/
git add README.md
```

---

## 📋 PASO 7: HACER COMMIT (Guardar cambios)

Guarda los cambios con un mensaje descriptivo:

```bash
git commit -m "Initial commit: API Movies with Category and Movie entities"
```

**O un mensaje más simple:**
```bash
git commit -m "Proyecto API Movies completo"
```

---

## 📋 PASO 8: CONECTAR CON TU REPOSITORIO DE GITHUB

Conecta tu repositorio local con el remoto en GitHub:

```bash
git remote add origin https://github.com/TU-USUARIO/API_MOVIES_ml.git
```

**Reemplaza `TU-USUARIO` con tu nombre de usuario de GitHub.**

**Ejemplo:**
```bash
git remote add origin https://github.com/malp0/API_MOVIES_ml.git
```

**Para verificar que se agregó correctamente:**
```bash
git remote -v
```

---

## 📋 PASO 9: SUBIR EL PROYECTO (PUSH)

Sube tu código a GitHub:

```bash
git branch -M main
git push -u origin main
```

**Si GitHub te pide autenticación:**
- Usa un **Personal Access Token** (no tu contraseña)
- Cómo crear uno: https://github.com/settings/tokens
- O usa GitHub Desktop (más fácil)

---

## 🔄 COMANDOS COMPLETOS (Resumen)

```bash
# 1. Navegar a la carpeta
cd "C:\Users\malp0\Downloads\API Peliculas\API.W.Movies-master\API.W.Movies-master"

# 2. Inicializar Git
git init

# 3. Agregar archivos
git add .

# 4. Hacer commit
git commit -m "Proyecto API Movies completo"

# 5. Conectar con GitHub (reemplaza TU-USUARIO)
git remote add origin https://github.com/TU-USUARIO/API_MOVIES_ml.git

# 6. Subir a GitHub
git branch -M main
git push -u origin main
```

---

## 🛠️ ALTERNATIVA: USAR GITHUB DESKTOP (MÁS FÁCIL)

Si prefieres una interfaz gráfica:

1. **Descarga GitHub Desktop:**
   - https://desktop.github.com/

2. **Instala y configura:**
   - Inicia sesión con tu cuenta de GitHub
   - Ve a File → Add Local Repository
   - Selecciona la carpeta del proyecto
   - Haz clic en "Publish repository"
   - Selecciona el repositorio `API_MOVIES_ml`

---

## ❓ PROBLEMAS COMUNES

### Error: "remote origin already exists"
```bash
git remote remove origin
git remote add origin https://github.com/TU-USUARIO/API_MOVIES_ml.git
```

### Error: "authentication failed"
- Usa un Personal Access Token en lugar de tu contraseña
- O usa GitHub Desktop

### Error: "not a git repository"
```bash
git init
```

### Verificar estado:
```bash
git status
```

---

## ✅ VERIFICACIÓN

Después de subir, verifica en GitHub:
1. Ve a: `https://github.com/TU-USUARIO/API_MOVIES_ml`
2. Deberías ver todos tus archivos
3. Deberías ver la carpeta `API.W.Movies/` con todo el código

---

## 📝 NOTA IMPORTANTE

**NO subas estos archivos (deben estar en .gitignore):**
- `bin/` y `obj/` (carpetas de compilación)
- `.vs/` (configuración de Visual Studio)
- Archivos `.user` y `.suo`
- `packages/` (paquetes NuGet)

**SÍ sube estos archivos:**
- ✅ Todo el código fuente (`.cs`)
- ✅ `appsettings.json` (sin contraseñas)
- ✅ `API.W.Movies.csproj`
- ✅ Carpeta `Migrations/`
- ✅ `README.md`

---

¡Listo! Tu proyecto estará en GitHub. 🚀

