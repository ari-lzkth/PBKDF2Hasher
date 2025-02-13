
# PBKDF2 Hasher

Dies ist eine einfache Konsolenanwendung in .NET 8, die den PBKDF2-Algorithmus zur sicheren Passwort-Hashing verwendet. Die Anwendung akzeptiert vier Eingabeparameter: Passwort, Salt (im Base64-Format), Iterationen und die L�nge des abgeleiteten Schl�ssels (`dkLen`). Sie verwendet den `Rfc2898DeriveBytes`-Konstruktor, um einen Hash zu generieren, der mit SHA-1 berechnet wird. Das Ergebnis wird als Base64-kodierter Hash zur�ckgegeben.

## Verwendung:

```bash
PBKDF2Hasher.exe <password> <salt> <iterations> <dkLen>
```

- `<password>`: Das Passwort, das gehasht werden soll.
- `<salt>`: Das Salt im Base64-Format.
- `<iterations>`: Die Anzahl der Iterationen f�r den PBKDF2-Algorithmus.
- `<dkLen>`: Die L�nge des abgeleiteten Schl�ssels (in Bytes).

### Beispiel:

```bash
PBKDF2Hasher.exe "MeinPasswort" "c29tZXNhbHQ=" 10000 32
```

### Aufruf aus Lotus Notes (beispiel)
```bash
cmd.exe /C "C:\Users\<USERNAME>\AppData\Local\Temp\PBKDF2Hasher.exe" "<PASSWORD>" "<SALT>" 1000 32
```

Dies erzeugt einen 32-Byte langen Hash, basierend auf den angegebenen Parametern.

## Erstellung der .EXE Datei

Um die Anwendung als einzelne ausf�hrbare Datei zu erstellen, kann der folgende Befehl verwendet werden. Dies wird eine selbstst�ndige `.EXE`-Datei erzeugen, die ohne zus�tzliche .NET-Installation auf einem Windows 64-Bit System ausgef�hrt werden kann.

```bash
dotnet publish -c Release -r win-x64 --self-contained true
```

Die `.EXE`-Datei wird im Verzeichnis `bin\Release\net8.0\win-x64\publish\` erstellt.
