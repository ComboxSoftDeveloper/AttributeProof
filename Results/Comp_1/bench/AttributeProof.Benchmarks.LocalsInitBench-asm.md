## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FF867E15EC0]; AttributeProof.Subjects.StackWithInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,0F3739EFA4C00
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       add       rax,0F
       shr       rax,4
       add       rsp,20
M01_L00:
       push      0
       push      0
       dec       rax
       jne       short M01_L00
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       dec       ecx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       r8,0F3739EFA4C00
       cmp       [rbp+8],r8
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FF867B87198]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 128
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithoutInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FF867DE5EC0]; AttributeProof.Subjects.StackWithoutInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithoutInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,64FF7AADE92E
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       mov       rdx,rax
       add       rdx,0F
       and       rdx,0FFFFFFFFFFFFFFF0
       add       rsp,20
       neg       rdx
       add       rdx,rsp
       jb        short M01_L00
       xor       edx,edx
M01_L00:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rdx
       jae       short M01_L00
       mov       rsp,rdx
       test      [rsp],esp
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       dec       ecx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       r8,64FF7AADE92E
       cmp       [rbp+8],r8
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FF867B57198]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 153
```

## .NET 8.0.31 (8.0.31, 8.0.3126.42015), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FF851FC6FE8]; AttributeProof.Subjects.StackWithInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,26A0E4754E39
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       add       rax,0F
       shr       rax,4
       add       rsp,20
M01_L00:
       push      0
       push      0
       dec       rax
       jne       short M01_L00
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       lea       edx,[rcx-1]
       cmp       edx,ecx
       jae       short M01_L04
       mov       ecx,edx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       rcx,26A0E4754E39
       cmp       [rbp+8],rcx
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FF851DF57E8]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 135
```

## .NET 8.0.31 (8.0.31, 8.0.3126.42015), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithoutInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FF851FC7000]; AttributeProof.Subjects.StackWithoutInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithoutInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,0EFF40F5227AA
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       mov       rdx,rax
       add       rdx,0F
       and       rdx,0FFFFFFFFFFFFFFF0
       add       rsp,20
       neg       rdx
       add       rdx,rsp
       jb        short M01_L00
       xor       edx,edx
M01_L00:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rdx
       jae       short M01_L00
       mov       rsp,rdx
       test      [rsp],esp
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       lea       edx,[rcx-1]
       cmp       edx,ecx
       jae       short M01_L04
       mov       ecx,edx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       rcx,0EFF40F5227AA
       cmp       [rbp+8],rcx
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FF851DF57E8]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 160
```

## .NET 9.0.20 (9.0.20, 9.0.2026.41315), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FF851F64DF8]; AttributeProof.Subjects.StackWithInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,1B43BA47F73C
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       add       rax,0F
       shr       rax,4
       add       rsp,20
M01_L00:
       push      0
       push      0
       dec       rax
       jne       short M01_L00
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       lea       edx,[rcx-1]
       cmp       edx,ecx
       jae       short M01_L04
       mov       ecx,edx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       rcx,1B43BA47F73C
       cmp       [rbp+8],rcx
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FF851C76D00]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 135
```

## .NET 9.0.20 (9.0.20, 9.0.2026.41315), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithoutInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FF851F44DF8]; AttributeProof.Subjects.StackWithoutInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithoutInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,456AF1741231
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       mov       rdx,rax
       add       rdx,0F
       and       rdx,0FFFFFFFFFFFFFFF0
       add       rsp,20
       neg       rdx
       add       rdx,rsp
       jb        short M01_L00
       xor       edx,edx
M01_L00:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rdx
       jae       short M01_L00
       mov       rsp,rdx
       test      [rsp],esp
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       lea       edx,[rcx-1]
       cmp       edx,ecx
       jae       short M01_L04
       mov       ecx,edx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       rcx,456AF1741231
       cmp       [rbp+8],rcx
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FF851C56D00]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 160
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FF867DE5DD0]; AttributeProof.Subjects.StackWithInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,0A7164317AA00
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       add       rax,0F
       shr       rax,4
       add       rsp,20
M01_L00:
       push      0
       push      0
       dec       rax
       jne       short M01_L00
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       dec       ecx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       r8,0A7164317AA00
       cmp       [rbp+8],r8
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FF867B57198]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 128
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithoutInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FF867E15EA8]; AttributeProof.Subjects.StackWithoutInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithoutInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,70FDFB3E895E
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       mov       rdx,rax
       add       rdx,0F
       and       rdx,0FFFFFFFFFFFFFFF0
       add       rsp,20
       neg       rdx
       add       rdx,rsp
       jb        short M01_L00
       xor       edx,edx
M01_L00:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rdx
       jae       short M01_L00
       mov       rsp,rdx
       test      [rsp],esp
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       dec       ecx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       r8,70FDFB3E895E
       cmp       [rbp+8],r8
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FF867B87198]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 153
```

## .NET 8.0.31 (8.0.31, 8.0.3126.42015), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FF851FD7318]; AttributeProof.Subjects.StackWithInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,4F51379552D5
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       add       rax,0F
       shr       rax,4
       add       rsp,20
M01_L00:
       push      0
       push      0
       dec       rax
       jne       short M01_L00
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       lea       edx,[rcx-1]
       cmp       edx,ecx
       jae       short M01_L04
       mov       ecx,edx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       rcx,4F51379552D5
       cmp       [rbp+8],rcx
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FF851E057E8]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 135
```

## .NET 8.0.31 (8.0.31, 8.0.3126.42015), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithoutInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FF851FB7330]; AttributeProof.Subjects.StackWithoutInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithoutInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,9033BC789F3A
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       mov       rdx,rax
       add       rdx,0F
       and       rdx,0FFFFFFFFFFFFFFF0
       add       rsp,20
       neg       rdx
       add       rdx,rsp
       jb        short M01_L00
       xor       edx,edx
M01_L00:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rdx
       jae       short M01_L00
       mov       rsp,rdx
       test      [rsp],esp
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       lea       edx,[rcx-1]
       cmp       edx,ecx
       jae       short M01_L04
       mov       ecx,edx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       rcx,9033BC789F3A
       cmp       [rbp+8],rcx
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FF851DE57E8]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 160
```

## .NET 9.0.20 (9.0.20, 9.0.2026.41315), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FF851F44D20]; AttributeProof.Subjects.StackWithInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,81F4EC623382
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       add       rax,0F
       shr       rax,4
       add       rsp,20
M01_L00:
       push      0
       push      0
       dec       rax
       jne       short M01_L00
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       lea       edx,[rcx-1]
       cmp       edx,ecx
       jae       short M01_L04
       mov       ecx,edx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       rcx,81F4EC623382
       cmp       [rbp+8],rcx
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FF851C56D00]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 135
```

## .NET 9.0.20 (9.0.20, 9.0.2026.41315), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithoutInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FF851F64D20]; AttributeProof.Subjects.StackWithoutInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithoutInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,0DDC1A400033B
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       mov       rdx,rax
       add       rdx,0F
       and       rdx,0FFFFFFFFFFFFFFF0
       add       rsp,20
       neg       rdx
       add       rdx,rsp
       jb        short M01_L00
       xor       edx,edx
M01_L00:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rdx
       jae       short M01_L00
       mov       rsp,rdx
       test      [rsp],esp
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       lea       edx,[rcx-1]
       cmp       edx,ecx
       jae       short M01_L04
       mov       ecx,edx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       rcx,0DDC1A400033B
       cmp       [rbp+8],rcx
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FF851C76D00]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 160
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FF867DE5DD0]; AttributeProof.Subjects.StackWithInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,25A9E71A47C4
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       add       rax,0F
       shr       rax,4
       add       rsp,20
M01_L00:
       push      0
       push      0
       dec       rax
       jne       short M01_L00
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       dec       ecx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       r8,25A9E71A47C4
       cmp       [rbp+8],r8
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FF867B57198]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 128
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithoutInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FF867E05EC0]; AttributeProof.Subjects.StackWithoutInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithoutInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,42CA4FEA2972
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       mov       rdx,rax
       add       rdx,0F
       and       rdx,0FFFFFFFFFFFFFFF0
       add       rsp,20
       neg       rdx
       add       rdx,rsp
       jb        short M01_L00
       xor       edx,edx
M01_L00:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rdx
       jae       short M01_L00
       mov       rsp,rdx
       test      [rsp],esp
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       dec       ecx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       r8,42CA4FEA2972
       cmp       [rbp+8],r8
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FF867B77198]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 153
```

## .NET 8.0.31 (8.0.31, 8.0.3126.42015), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FF851FB6FE8]; AttributeProof.Subjects.StackWithInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,691017044543
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       add       rax,0F
       shr       rax,4
       add       rsp,20
M01_L00:
       push      0
       push      0
       dec       rax
       jne       short M01_L00
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       lea       edx,[rcx-1]
       cmp       edx,ecx
       jae       short M01_L04
       mov       ecx,edx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       rcx,691017044543
       cmp       [rbp+8],rcx
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FF851DE57E8]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 135
```

## .NET 8.0.31 (8.0.31, 8.0.3126.42015), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithoutInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FF851FD7330]; AttributeProof.Subjects.StackWithoutInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithoutInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,862197FD3C9A
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       mov       rdx,rax
       add       rdx,0F
       and       rdx,0FFFFFFFFFFFFFFF0
       add       rsp,20
       neg       rdx
       add       rdx,rsp
       jb        short M01_L00
       xor       edx,edx
M01_L00:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rdx
       jae       short M01_L00
       mov       rsp,rdx
       test      [rsp],esp
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       lea       edx,[rcx-1]
       cmp       edx,ecx
       jae       short M01_L04
       mov       ecx,edx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       rcx,862197FD3C9A
       cmp       [rbp+8],rcx
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FF851E057E8]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 160
```

## .NET 9.0.20 (9.0.20, 9.0.2026.41315), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FF8538D4D20]; AttributeProof.Subjects.StackWithInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,0CC1DFE7C8E3B
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       add       rax,0F
       shr       rax,4
       add       rsp,20
M01_L00:
       push      0
       push      0
       dec       rax
       jne       short M01_L00
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       lea       edx,[rcx-1]
       cmp       edx,ecx
       jae       short M01_L04
       mov       ecx,edx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       rcx,0CC1DFE7C8E3B
       cmp       [rbp+8],rcx
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FF8535E6D00]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 135
```

## .NET 9.0.20 (9.0.20, 9.0.2026.41315), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithoutInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FF8538D4D20]; AttributeProof.Subjects.StackWithoutInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithoutInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,0B526CC3B13FD
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       mov       rdx,rax
       add       rdx,0F
       and       rdx,0FFFFFFFFFFFFFFF0
       add       rsp,20
       neg       rdx
       add       rdx,rsp
       jb        short M01_L00
       xor       edx,edx
M01_L00:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rdx
       jae       short M01_L00
       mov       rsp,rdx
       test      [rsp],esp
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       lea       edx,[rcx-1]
       cmp       edx,ecx
       jae       short M01_L04
       mov       ecx,edx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       rcx,0B526CC3B13FD
       cmp       [rbp+8],rcx
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FF8535E6D00]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 160
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FF867E25EC0]; AttributeProof.Subjects.StackWithInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,794124277299
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       add       rax,0F
       shr       rax,4
       add       rsp,20
M01_L00:
       push      0
       push      0
       dec       rax
       jne       short M01_L00
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       dec       ecx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       r8,794124277299
       cmp       [rbp+8],r8
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FF867B97198]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 128
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithoutInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FF867DE5DD0]; AttributeProof.Subjects.StackWithoutInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithoutInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,87DE29485811
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       mov       rdx,rax
       add       rdx,0F
       and       rdx,0FFFFFFFFFFFFFFF0
       add       rsp,20
       neg       rdx
       add       rdx,rsp
       jb        short M01_L00
       xor       edx,edx
M01_L00:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rdx
       jae       short M01_L00
       mov       rsp,rdx
       test      [rsp],esp
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       dec       ecx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       r8,87DE29485811
       cmp       [rbp+8],r8
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FF867B57198]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 153
```

## .NET 8.0.31 (8.0.31, 8.0.3126.42015), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FF851DF7318]; AttributeProof.Subjects.StackWithInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,3BEBA446C303
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       add       rax,0F
       shr       rax,4
       add       rsp,20
M01_L00:
       push      0
       push      0
       dec       rax
       jne       short M01_L00
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       lea       edx,[rcx-1]
       cmp       edx,ecx
       jae       short M01_L04
       mov       ecx,edx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       rcx,3BEBA446C303
       cmp       [rbp+8],rcx
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FF851C257E8]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 135
```

## .NET 8.0.31 (8.0.31, 8.0.3126.42015), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithoutInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FF851E17330]; AttributeProof.Subjects.StackWithoutInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithoutInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,6C3F02ABBE66
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       mov       rdx,rax
       add       rdx,0F
       and       rdx,0FFFFFFFFFFFFFFF0
       add       rsp,20
       neg       rdx
       add       rdx,rsp
       jb        short M01_L00
       xor       edx,edx
M01_L00:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rdx
       jae       short M01_L00
       mov       rsp,rdx
       test      [rsp],esp
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       lea       edx,[rcx-1]
       cmp       edx,ecx
       jae       short M01_L04
       mov       ecx,edx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       rcx,6C3F02ABBE66
       cmp       [rbp+8],rcx
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FF851C457E8]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 160
```

## .NET 9.0.20 (9.0.20, 9.0.2026.41315), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FF8538B4D20]; AttributeProof.Subjects.StackWithInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,65A8ABBD9B92
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       add       rax,0F
       shr       rax,4
       add       rsp,20
M01_L00:
       push      0
       push      0
       dec       rax
       jne       short M01_L00
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       lea       edx,[rcx-1]
       cmp       edx,ecx
       jae       short M01_L04
       mov       ecx,edx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       rcx,65A8ABBD9B92
       cmp       [rbp+8],rcx
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FF8535C6D00]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 135
```

## .NET 9.0.20 (9.0.20, 9.0.2026.41315), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithoutInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FF8538A4D20]; AttributeProof.Subjects.StackWithoutInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithoutInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,4C9384EEEC55
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       mov       rdx,rax
       add       rdx,0F
       and       rdx,0FFFFFFFFFFFFFFF0
       add       rsp,20
       neg       rdx
       add       rdx,rsp
       jb        short M01_L00
       xor       edx,edx
M01_L00:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rdx
       jae       short M01_L00
       mov       rsp,rdx
       test      [rsp],esp
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       lea       edx,[rcx-1]
       cmp       edx,ecx
       jae       short M01_L04
       mov       ecx,edx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       rcx,4C9384EEEC55
       cmp       [rbp+8],rcx
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FF8535B6D00]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 160
```

