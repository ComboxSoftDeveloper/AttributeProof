## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

```assembly
; AttributeProof.Benchmarks.ArgumentBench.Library()
       mov       rcx,203753E8B08
       jmp       qword ptr [7FFADAD0FAE0]; AttributeProof.Subjects.CheckByLibrary(System.String)
; Total bytes of code 16
```
```assembly
; AttributeProof.Subjects.CheckByLibrary(System.String)
       sub       rsp,28
       test      rcx,rcx
       je        short M01_L00
       mov       eax,[rcx+8]
       add       rsp,28
       ret
M01_L00:
       mov       ecx,67
       mov       rdx,7FFADABE8418
       call      qword ptr [7FFADA9AF210]
       mov       rcx,rax
       call      qword ptr [7FFADAD85998]
       int       3
; Total bytes of code 48
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

```assembly
; AttributeProof.Benchmarks.ArgumentBench.ByHand()
       mov       rcx,2EA15888B08
       jmp       qword ptr [7FFADACFF9F0]; AttributeProof.Subjects.CheckByHand(System.String)
; Total bytes of code 16
```
```assembly
; AttributeProof.Subjects.CheckByHand(System.String)
       push      rbx
       sub       rsp,20
       test      rcx,rcx
       je        short M01_L00
       mov       eax,[rcx+8]
       add       rsp,20
       pop       rbx
       ret
M01_L00:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,67
       mov       rdx,7FFADABD8418
       call      qword ptr [7FFADA99F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFADAC673F0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 79
```

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

```assembly
; AttributeProof.Benchmarks.ArgumentBench.Library()
       mov       rcx,25826D68DA8
       jmp       qword ptr [7FFACEB7CED0]; AttributeProof.Subjects.CheckByLibrary(System.String)
; Total bytes of code 16
```
```assembly
; AttributeProof.Subjects.CheckByLibrary(System.String)
       sub       rsp,28
       test      rcx,rcx
       je        short M01_L00
       mov       eax,[rcx+8]
       add       rsp,28
       ret
M01_L00:
       mov       ecx,67
       mov       rdx,7FFACE951528
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFACE9366E8]
       int       3
; Total bytes of code 47
```

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

```assembly
; AttributeProof.Benchmarks.ArgumentBench.ByHand()
       mov       rcx,253D5878DA8
       jmp       qword ptr [7FFACEB5CEE8]; AttributeProof.Subjects.CheckByHand(System.String)
; Total bytes of code 16
```
```assembly
; AttributeProof.Subjects.CheckByHand(System.String)
       push      rbx
       sub       rsp,20
       test      rcx,rcx
       je        short M01_L00
       mov       eax,[rcx+8]
       add       rsp,20
       pop       rbx
       ret
M01_L00:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,67
       mov       rdx,7FFACE931528
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFACE916640]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 78
```

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

```assembly
; AttributeProof.Benchmarks.ArgumentBench.Library()
       mov       rcx,238484C9058
       jmp       qword ptr [7FFACEA5EB98]; AttributeProof.Subjects.CheckByLibrary(System.String)
; Total bytes of code 16
```
```assembly
; AttributeProof.Subjects.CheckByLibrary(System.String)
       sub       rsp,28
       test      rcx,rcx
       je        short M01_L00
       mov       eax,[rcx+8]
       add       rsp,28
       ret
M01_L00:
       mov       ecx,67
       mov       rdx,7FFACE935CD8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFACEB24BE8]
       int       3
; Total bytes of code 47
```

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

```assembly
; AttributeProof.Benchmarks.ArgumentBench.ByHand()
       mov       rcx,28EB5529058
       jmp       qword ptr [7FFACEA7EAD8]; AttributeProof.Subjects.CheckByHand(System.String)
; Total bytes of code 16
```
```assembly
; AttributeProof.Subjects.CheckByHand(System.String)
       push      rbx
       sub       rsp,20
       test      rcx,rcx
       je        short M01_L00
       mov       eax,[rcx+8]
       add       rsp,20
       pop       rbx
       ret
M01_L00:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,67
       mov       rdx,7FFACE955CD8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFACE9E66B8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 78
```

