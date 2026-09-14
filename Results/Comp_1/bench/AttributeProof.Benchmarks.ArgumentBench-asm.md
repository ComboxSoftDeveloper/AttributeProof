## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

```assembly
; AttributeProof.Benchmarks.ArgumentBench.Library()
       mov       rcx,1D07902B1B0
       jmp       qword ptr [7FF867DF5E90]; AttributeProof.Subjects.CheckByLibrary(System.String)
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
       mov       rdx,7FF867CC2E20
       call      qword ptr [7FF867C17798]
       mov       rcx,rax
       call      qword ptr [7FF867DFC018]
       int       3
; Total bytes of code 48
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

```assembly
; AttributeProof.Benchmarks.ArgumentBench.ByHand()
       mov       rcx,1FCDCCFB1B0
       jmp       qword ptr [7FF867E15E90]; AttributeProof.Subjects.CheckByHand(System.String)
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
       mov       rdx,7FF867CE2E20
       call      qword ptr [7FF867C37798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF867D654A0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 79
```

## .NET 8.0.31 (8.0.31, 8.0.3126.42015), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

```assembly
; AttributeProof.Benchmarks.ArgumentBench.Library()
       mov       rcx,1E27764B468
       jmp       qword ptr [7FF851FD7060]; AttributeProof.Subjects.CheckByLibrary(System.String)
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
       mov       rdx,7FF851E252A0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF851C86790]
       int       3
; Total bytes of code 47
```

## .NET 8.0.31 (8.0.31, 8.0.3126.42015), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

```assembly
; AttributeProof.Benchmarks.ArgumentBench.ByHand()
       mov       rcx,237E30AB468
       jmp       qword ptr [7FF851FD73A8]; AttributeProof.Subjects.CheckByHand(System.String)
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
       mov       rdx,7FF851E252A0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF851C866E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 78
```

## .NET 9.0.20 (9.0.20, 9.0.2026.41315), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

```assembly
; AttributeProof.Benchmarks.ArgumentBench.Library()
       mov       rcx,31D26B9B728
       jmp       qword ptr [7FF851F54DC8]; AttributeProof.Subjects.CheckByLibrary(System.String)
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
       mov       rdx,7FF851DE7C40
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF851F570F0]
       int       3
; Total bytes of code 47
```

## .NET 9.0.20 (9.0.20, 9.0.2026.41315), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

```assembly
; AttributeProof.Benchmarks.ArgumentBench.ByHand()
       mov       rcx,2CE2A7CB728
       jmp       qword ptr [7FF851F64CF0]; AttributeProof.Subjects.CheckByHand(System.String)
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
       mov       rdx,7FF851DF7C40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF851E84510]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 78
```

